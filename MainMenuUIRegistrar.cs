using Core.Localization;
using HarmonyLib;
using Menu.MainMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Shapez2UILib
{
    public static class MainMenuUIRegistrar
    {
        private static readonly List<UIRegistration> registrations = new List<UIRegistration>();
        [HarmonyPatch(typeof(HUDMainMenuUI), "Construct")]
        [HarmonyPrefix]
        private static void HUDMainMenuUIConstructPrefix(HUDMainMenuUI __instance, ref HUDComponent[] ___ChildComponentReferences)
        {
            HUDMenuPlayState hudMenuPlayState = __instance.GetComponentInChildren<HUDMenuPlayState>(true);
            RectTransform fromRect = hudMenuPlayState.GetComponent<RectTransform>();
            GameObject backButtonGameObject = hudMenuPlayState.transform.Find("BackButton").gameObject;
            RectTransform originalMainContentRectTransform = hudMenuPlayState.transform.Find("MainContent").GetComponent<RectTransform>();
            foreach (var registration in registrations)
            {
                GameObject gameObject = new GameObject(registration.name);
                gameObject.transform.SetParent(__instance.transform);
                gameObject.transform.localPosition = hudMenuPlayState.transform.localPosition;
                gameObject.transform.localScale = Vector3.one;
                RectTransform toRect = gameObject.AddComponent<RectTransform>();
                toRect.anchorMin = fromRect.anchorMin;
                toRect.anchorMax = fromRect.anchorMax;
                toRect.pivot = fromRect.pivot;
                toRect.anchoredPosition = fromRect.anchoredPosition;
                toRect.sizeDelta = fromRect.sizeDelta;
                gameObject.layer = hudMenuPlayState.gameObject.layer;
                gameObject.AddComponent<Canvas>();
                gameObject.AddComponent<GraphicRaycaster>();
                HUDMainMenuState ui = (HUDMainMenuState)gameObject.AddComponent(registration.type);
                if (registration.addMainPanel)
                {
                    GameObject mainContent = new GameObject("MainContent");
                    mainContent.transform.SetParent(gameObject.transform);
                    mainContent.layer = LayerMask.NameToLayer("UI");
                    mainContent.transform.localScale = Vector3.one;
                    RectTransform mainContentRectTransform = mainContent.AddComponent<RectTransform>();
                    mainContentRectTransform.anchorMin = originalMainContentRectTransform.anchorMin;
                    mainContentRectTransform.anchorMax = originalMainContentRectTransform.anchorMax;
                    mainContentRectTransform.pivot = originalMainContentRectTransform.pivot;
                    mainContentRectTransform.anchoredPosition = originalMainContentRectTransform.anchoredPosition;
                    mainContentRectTransform.sizeDelta = originalMainContentRectTransform.sizeDelta;
                    UIFactory.AddPanel(mainContentRectTransform, ui);
                }
                if (registration.addBackButton)
                {
                    GameObject backButton = GameObject.Instantiate(backButtonGameObject, gameObject.transform);
                    backButton.transform.localPosition = backButtonGameObject.transform.localPosition;
                    HUDMenuBackButton hudMenuBackButton = backButton.GetComponent<HUDMenuBackButton>();
                    hudMenuBackButton.SetChildComponentReferences(new HUDComponent[] { backButton.GetComponentInChildren<HUDLocalizedText>(), backButton.GetComponentInChildren<HUDAnimatedRoundButton>() });
                    StaticResources.HUDMenuBackButton_TextIdInfo.SetValue(hudMenuBackButton, new SerializedTranslationId() { Id = new TranslationId(registration.nameTranslationId) });
                    hudMenuBackButton.OnClick.AddListener(ui.GoBack);
                }
                registration.createUIFunc.Invoke(ui);
                registration.instance = ui;
                __instance.AddChildViewInternal(registration.type, ui);
            }
            ___ChildComponentReferences = ___ChildComponentReferences.Concat(registrations.Select(r => r.instance!)).ToArray();
        }
        [HarmonyPatch(typeof(HUDMenuMainState), "AddMenuButton")]
        [HarmonyPostfix]
        private static void AddMenuButtonPostfix(IText text, HUDMenuMainState __instance, IMainMenuStateControl ___Menu)
        {
            if (text is LazyLocalizedText lazyText)
            {
                foreach (var registration in registrations)
                {
                    if (lazyText.Id.Id == registration.addAfter)
                    {
                        StaticResources.addMenuButtonMethod.Invoke(__instance, new object[] { registration.buttonText, new UnityAction(() => {
                            StaticResources.IMainMenuStateControlSwitchToStateInfo.MakeGenericMethod(registration.type).Invoke(___Menu, new object[] { null });
                        }) });
                    }
                }
            }
        }
        [HarmonyPatch(typeof(MainMenuOrchestrator), "Step_0_2_InitStates")]
        [HarmonyPrefix]
        private static void MainMenuOrchestratorInitStatesPrefix(Dictionary<string, MainMenuStateManager.CameraState> ___UICameraStatesDict)
        {
            foreach (var registration in registrations)
            {
                ___UICameraStatesDict.Add(registration.name, (registration.pullCameraStateFrom != null ? ___UICameraStatesDict[registration.pullCameraStateFrom] : null) ?? registration.cameraState ?? registration.cameraStateGenerator?.Invoke(___UICameraStatesDict) ?? ___UICameraStatesDict["Play"]);
            }
        }
        /// <summary>
        /// Registers a UI to the Main Menu
        /// </summary>
        /// <typeparam name="T">your UI class</typeparam>
        /// <param name="createUIFunc">use this to add elements to your ui using UIFactory</param>
        /// <param name="name">the name of your ui</param>
        /// <param name="buttonText">the text to use for the main menu button</param>
        /// <param name="nameTranslationId">the translation id for the text for the menu back button</param>
        /// <param name="addAfter">the translation id of the main menu button to add your main menu button after</param>
        /// <param name="pullCameraStateFrom">the menu the camera state is pulled from</param>
        /// <param name="addBackButton">if the back button should be added and set up</param>
        /// <param name="addMainPanel">if the main panel should be created for you</param>
        public static void RegisterUI<T>(Action<T> createUIFunc, string name, IText buttonText, string nameTranslationId, string addAfter, string pullCameraStateFrom = "Play", bool addBackButton = true, bool addMainPanel = true) where T : HUDMainMenuState
        {
            registrations.Add(new UIRegistration() { createUIFunc = state => createUIFunc.Invoke((T)state), name = name, buttonText = buttonText, nameTranslationId = nameTranslationId, addAfter = addAfter, pullCameraStateFrom = pullCameraStateFrom, addBackButton = addBackButton, addMainPanel = addMainPanel, type = typeof(T) });
        }
        /// <summary>
        /// Registers a UI to the Main Menu
        /// </summary>
        /// <typeparam name="T">your UI class</typeparam>
        /// <param name="createUIFunc">use this to add elements to your ui using UIFactory</param>
        /// <param name="name">the name of your ui</param>
        /// <param name="buttonText">the text to use for the main menu button</param>
        /// <param name="nameTranslationId">the translation id for the text for the menu back button</param>
        /// <param name="addAfter">the translation id of the main menu button to add your main menu button after</param>
        /// <param name="cameraState">the camera state for the menu</param>
        /// <param name="addBackButton">if the back button should be added and set up</param>
        /// <param name="addMainPanel">if the main panel should be created for you</param>
        public static void RegisterUI<T>(Action<T> createUIFunc, string name, IText buttonText, string nameTranslationId, string addAfter, MainMenuStateManager.CameraState cameraState, bool addBackButton = true, bool addMainPanel = true) where T : HUDMainMenuState
        {
            registrations.Add(new UIRegistration() { createUIFunc = state => createUIFunc.Invoke((T)state), name = name, buttonText = buttonText, nameTranslationId = nameTranslationId, addAfter = addAfter, cameraState = cameraState, addBackButton = addBackButton, addMainPanel = addMainPanel, type = typeof(T) });
        }
        /// <summary>
        /// Registers a UI to the Main Menu
        /// </summary>
        /// <typeparam name="T">your UI class</typeparam>
        /// <param name="createUIFunc">use this to add elements to your ui using UIFactory</param>
        /// <param name="name">the name of your ui</param>
        /// <param name="buttonText">the text to use for the main menu button</param>
        /// <param name="nameTranslationId">the translation id for the text for the menu back button</param>
        /// <param name="addAfter">the translation id of the main menu button to add your main menu button after</param>
        /// <param name="cameraState">the camera state for the menu</param>
        /// <param name="addBackButton">if the back button should be added and set up</param>
        /// <param name="addMainPanel">if the main panel should be created for you</param>
        public static void RegisterUI<T>(Action<T> createUIFunc, string name, IText buttonText, string nameTranslationId, string addAfter, Func<Dictionary<string, MainMenuStateManager.CameraState>, MainMenuStateManager.CameraState> cameraStateGenerator, bool addBackButton = true, bool addMainPanel = true) where T : HUDMainMenuState
        {
            registrations.Add(new UIRegistration() { createUIFunc = state => createUIFunc.Invoke((T)state), name = name, buttonText = buttonText, nameTranslationId = nameTranslationId, addAfter = addAfter, cameraStateGenerator = cameraStateGenerator, addBackButton = addBackButton, addMainPanel = addMainPanel, type = typeof(T) });
        }
        private class UIRegistration
        {
            public Action<HUDMainMenuState> createUIFunc;
            public string name;
            public IText buttonText;
            public string nameTranslationId;
            public string addAfter;
            public string? pullCameraStateFrom;
            public MainMenuStateManager.CameraState? cameraState;
            public Func<Dictionary<string, MainMenuStateManager.CameraState>, MainMenuStateManager.CameraState>? cameraStateGenerator;
            public bool addBackButton;
            public bool addMainPanel;
            public Type type;
            public HUDMainMenuState? instance;
        }
    }
}
