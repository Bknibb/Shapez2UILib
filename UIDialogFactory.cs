using Core.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.Core.Prefabs;
using UnityEngine;

namespace Shapez2UILib
{
    public static class UIDialogFactory
    {
        private static readonly List<DialogCreation> dialogs = new List<DialogCreation>();
        static UIDialogFactory()
        {
            UIHook.HookLateStart(() =>
            {
                foreach (var dialog in dialogs) DoCreateDialog(dialog);
            });
        }
        /// <summary>
        /// helper to create a dialog, store the result from resultConsumer
        /// </summary>
        /// <typeparam name="T">the type to add</typeparam>
        /// <param name="uiConstructor">use this to add elements to the custom dialog</param>
        /// <param name="resultConsumer">store the resulting dialog from here</param>
        /// <param name="name">the name of the custom dialog</param>
        /// <param name="title">the title to show on the custom dialog</param>
        public static void CreateDialog<T>(Action<T, Transform> uiConstructor, Action<PrefabReference<T>> resultConsumer, string name, TranslationId? title = null) where T : HUDDialog
        {
            var dialog = new DialogCreation() { type = typeof(T), uiConstructor = (component, transform) => uiConstructor.Invoke((T)component, transform), resultConsumer = result => resultConsumer.Invoke(new PrefabReference<T>((T)result.Resolve())), name = name, title = title };
            dialogs.Add(dialog);
            if (UIHook.RanLateStarts) DoCreateDialog(dialog);
        }
        private static void DoCreateDialog(DialogCreation dialogData)
        {
            GameObject dialog = new GameObject(dialogData.name);
            dialog.SetActiveSelfExt(false);
            GameObject.DontDestroyOnLoad(dialog);
            dialog.layer = LayerMask.NameToLayer("UI");
            var dialogClass = (HUDDialog)dialog.AddComponent(dialogData.type);
            var dialogRectTransform = dialog.AddComponent<RectTransform>();
            dialogRectTransform.anchorMin = Vector2.zero;
            dialogRectTransform.anchorMax = Vector2.one;
            dialogRectTransform.offsetMin = Vector2.zero;
            dialogRectTransform.offsetMax = Vector2.zero;
            GameObject background = GameObject.Instantiate(Globals.Resources.UIDialogSimpleInfoPrefab.Resolve().transform.GetChild(0).gameObject, dialogRectTransform, false);
            var hudDialogPrefabReferences = dialog.AddComponent<HUDDialogPrefabReferences>();
            dialogClass.UIReferences = hudDialogPrefabReferences;
            var canvasGroup = dialog.AddComponent<CanvasGroup>();
            canvasGroup.blocksRaycasts = true;
            canvasGroup.ignoreParentGroups = false;
            canvasGroup.interactable = true;
            hudDialogPrefabReferences.UIMainCanvasGroup = canvasGroup;
            GameObject panelCenter = new GameObject("PanelCenter");
            panelCenter.layer = LayerMask.NameToLayer("UI");
            panelCenter.transform.SetParent(dialogRectTransform);
            var panelCenterRectTransform = panelCenter.AddComponent<RectTransform>();
            panelCenterRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            panelCenterRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            panelCenterRectTransform.offsetMin = new Vector2(-50f, -50f);
            panelCenterRectTransform.offsetMax = new Vector2(50f, 50f);
            GameObject mainPanel = new GameObject("MainPanel");
            mainPanel.layer = LayerMask.NameToLayer("UI");
            mainPanel.transform.SetParent(panelCenterRectTransform);
            var mainPanelRectTransform = mainPanel.AddComponent<RectTransform>();
            mainPanelRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            mainPanelRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            mainPanelRectTransform.sizeDelta = new Vector2(1250f, 800f);
            hudDialogPrefabReferences.UIDialogPanel = mainPanelRectTransform;
            UIFactory.AddPanel(mainPanelRectTransform, dialogClass);
            HUDLocalizedText HUDHeading = UIFactory.AddLocalizedTextPrimary(mainPanelRectTransform, dialogClass);
            if (dialogData.title.HasValue) HUDHeading.SetSerializedText(dialogData.title.Value);
            hudDialogPrefabReferences.UITitleText = HUDHeading;
            var hudHeadingRectTransform = HUDHeading.GetComponent<RectTransform>();
            hudHeadingRectTransform.anchorMin = Vector2.up;
            hudHeadingRectTransform.anchorMax = Vector2.one;
            hudHeadingRectTransform.offsetMin = new Vector2(10f, -90f);
            hudHeadingRectTransform.offsetMax = new Vector2(-10f, 0f);
            HUDHeading.Alignment = TMPro.TextAlignmentOptions.Left;
            HUDHeading.GetComponent<TextMeshProUGUI>().fontSizeMax = 32;
            GameObject divider = UIFactory.AddDivider(mainPanelRectTransform, scroll: false);
            var dividerRectTransform = divider.GetComponent<RectTransform>();
            dividerRectTransform.anchoredPosition = new Vector2(0, -90f);
            GameObject closeButton = GameObject.Instantiate(Globals.Resources.UIDialogSimpleInfoPrefab.Resolve().transform.GetChild(1).GetChild(0).GetChild(3).gameObject, mainPanelRectTransform);
            closeButton.SetActiveSelfExt(true);
            var closeButtonButton = closeButton.GetComponentInChildren<HUDAnimatedRoundButton>();
            dialogClass.AddChildComponentReference(closeButtonButton);
            hudDialogPrefabReferences.UICloseButton = closeButtonButton;
            GameObject contents = new GameObject("Contents");
            contents.layer = LayerMask.NameToLayer("UI");
            contents.transform.SetParent(mainPanel.transform);
            var contentsRectTransform = contents.AddComponent<RectTransform>();
            contentsRectTransform.anchorMin = Vector2.zero;
            contentsRectTransform.anchorMax = Vector2.one;
            contentsRectTransform.offsetMin = new Vector2(0f, 0f);
            contentsRectTransform.offsetMax = new Vector2(0f, -90f);
            dialogData.uiConstructor.Invoke(dialogClass, contentsRectTransform);
            dialogData.resultConsumer.Invoke(new PrefabReference<HUDDialog>(dialogClass));
        }
        public class DialogCreation
        {
            public Type type;
            public Action<HUDDialog, Transform> uiConstructor;
            public Action<PrefabReference<HUDDialog>> resultConsumer;
            public string name;
            public TranslationId? title;
        }
    }
}
