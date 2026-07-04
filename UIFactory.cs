using LeTai.Asset.TranslucentImage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;
using static Shapez2UILib.StaticResources;

namespace Shapez2UILib
{
    public static class UIFactory
    {
        private static readonly GameObject Panel = CreatePanel();
        private static readonly GameObject SecondaryPanel = CreateSecondaryPanel();
        private static readonly HUDButton Button = CreateButton();
        private static readonly HUDAnimatedRoundButton AnimatedRoundButton = CreateAnimatedRoundButton();
        private static readonly TextMeshProUGUI TextPrimary = CreateTextPrimary();
        private static readonly TextMeshProUGUI TextSecondary = CreateTextSecondary();
        private static readonly HUDLocalizedText LocalizedTextPrimary = CreateLocalizedTextPrimary();
        private static readonly HUDLocalizedText LocalizedTextSecondary = CreateLocalizedTextSecondary();
        private static readonly HUDInputField InputField = CreateInputField();
        private static readonly HUDScrollContainer ScrollContainer = CreateScrollContainer();
        private static readonly GameObject Divider = CreateDivider();
        private static readonly HUDIconButton IconButton = CreateIconButton();
        private static readonly HUDToggleControl Toggle = CreateToggle();
        private static readonly HUDDropdownControl Dropdown = CreateDropdown();
        private static readonly HUDEnumSelectorControl EnumSelector = CreateEnumSelector();
        private static readonly HUDSliderControl Slider = CreateSlider();
        private static GameObject CreatePanel()
        {
            GameObject Panel = new GameObject("Panel");
            GameObject.DontDestroyOnLoad(Panel);
            Panel.SetActiveSelfExt(false);
            Panel.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = Panel.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            GameObject Translucent = new GameObject("Translucent");
            Translucent.transform.SetParent(Panel.transform);
            Translucent.layer = LayerMask.NameToLayer("UI");
            RectTransform translucentRectTransform = Translucent.AddComponent<RectTransform>();
            translucentRectTransform.anchorMin = Vector2.zero;
            translucentRectTransform.anchorMax = Vector2.one;
            translucentRectTransform.offsetMin = new Vector2(-15.8316f, -15.8316f);
            translucentRectTransform.offsetMax = new Vector2(15.8316f, 15.8316f);
            TranslucentImage translucentImage = Translucent.AddComponent<TranslucentImage>();
            translucentImage.foregroundOpacity = 0;
            translucentImage.vibrancy = 0.5f;
            translucentImage.material = DefaultTranslucent;
            translucentImage.sprite = HUDPrimaryLightPanelMask;
            translucentImage.type = Image.Type.Sliced;
            translucentImage.raycastPadding = Vector4.zero;
            translucentImage.raycastTarget = false;
            Translucent.AddComponent<HUDTranslucentImageWithCameraResultAsImageSource>();
            GameObject Anim = new GameObject("Anim");
            Anim.transform.SetParent(Panel.transform);
            Anim.layer = LayerMask.NameToLayer("UI");
            RectTransform animRectTransform = Anim.AddComponent<RectTransform>();
            animRectTransform.anchorMin = Vector2.zero;
            animRectTransform.anchorMax = Vector2.one;
            animRectTransform.offsetMin = new Vector2(-15.8316f, -15.8316f);
            animRectTransform.offsetMax = new Vector2(15.8316f, 15.8316f);
            Image animImage = Anim.AddComponent<Image>();
            animImage.sprite = HUDPrimaryLightPanelMask;
            animImage.material = UIAnimatedPanelMenuMaterial;
            animImage.type = Image.Type.Sliced;
            animImage.color = new Color(0.1686f, 0.251f, 0.3412f, 0.502f);
            animImage.raycastPadding = new Vector4(15, 15, 15, 15);
            animImage.raycastTarget = false;
            GameObject PanelPanel = new GameObject("Panel");
            PanelPanel.transform.SetParent(Panel.transform);
            PanelPanel.layer = LayerMask.NameToLayer("UI");
            RectTransform panelPanelRectTransform = PanelPanel.AddComponent<RectTransform>();
            panelPanelRectTransform.anchorMin = Vector2.zero;
            panelPanelRectTransform.anchorMax = Vector2.one;
            panelPanelRectTransform.offsetMin = new Vector2(-15.8316f, -15.8316f);
            panelPanelRectTransform.offsetMax = new Vector2(15.8316f, 15.8316f);
            Image panelPanelImage = PanelPanel.AddComponent<Image>();
            panelPanelImage.sprite = HUDPrimaryLightPanel;
            panelPanelImage.material = UISpriteWithMipMapBiasOverride;
            panelPanelImage.type = Image.Type.Sliced;
            panelPanelImage.raycastPadding = new Vector4(15, 15, 15, 15);
            panelPanelImage.raycastTarget = true;
            return Panel;
        }
        private static GameObject CreateSecondaryPanel()
        {
            GameObject SecondaryPanel = new GameObject("Secondary Panel");
            GameObject.DontDestroyOnLoad(SecondaryPanel);
            SecondaryPanel.SetActiveSelfExt(false);
            SecondaryPanel.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = SecondaryPanel.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            GameObject PanelPanel = new GameObject("Panel");
            PanelPanel.transform.SetParent(SecondaryPanel.transform);
            PanelPanel.layer = LayerMask.NameToLayer("UI");
            RectTransform panelPanelRectTransform = PanelPanel.AddComponent<RectTransform>();
            panelPanelRectTransform.anchorMin = Vector2.zero;
            panelPanelRectTransform.anchorMax = Vector2.one;
            panelPanelRectTransform.offsetMin = new Vector2(-16.4378f, -16.438f);
            panelPanelRectTransform.offsetMax = new Vector2(16.4378f, 16.438f);
            Image panelPanelImage = PanelPanel.AddComponent<Image>();
            panelPanelImage.sprite = HUDSecondaryPanel;
            panelPanelImage.material = UIAnimatedSecondaryPanelMaterial;
            panelPanelImage.type = Image.Type.Sliced;
            panelPanelImage.raycastPadding = new Vector4(14, 14, 14, 14);
            panelPanelImage.raycastTarget = true;
            return SecondaryPanel;
        }
        private static HUDButton CreateButton()
        {
            GameObject Button = new GameObject("Button");
            GameObject.DontDestroyOnLoad(Button);
            Button.SetActiveSelfExt(false);
            Button.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = Button.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            CanvasGroup canvasGroup = Button.AddComponent<CanvasGroup>();
            canvasGroup.alpha = 1;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.ignoreParentGroups = false;
            canvasGroup.interactable = true;
            GameObject Bg = new GameObject("Bg");
            Bg.transform.SetParent(Button.transform);
            Bg.layer = LayerMask.NameToLayer("UI");
            RectTransform bgRectTransform = Bg.AddComponent<RectTransform>();
            bgRectTransform.anchorMin = Vector2.zero;
            bgRectTransform.anchorMax = Vector2.one;
            bgRectTransform.offsetMin = new Vector2(-12.182f, -11.9783f);
            bgRectTransform.offsetMax = new Vector2(12.182f, 11.9783f);
            Image bgImage = Bg.AddComponent<Image>();
            bgImage.sprite = HUDButtonBase;
            bgImage.material = UIAnimatedButtonMaterial;
            bgImage.type = Image.Type.Sliced;
            bgImage.raycastPadding = new Vector4(8, 8, 8, 8);
            bgImage.pixelsPerUnitMultiplier = 1.42f;
            GameObject HoverIndicator = new GameObject("HoverIndicator");
            HoverIndicator.transform.SetParent(Button.transform);
            HoverIndicator.layer = LayerMask.NameToLayer("UI");
            RectTransform hoverIndicatorRectTransform = HoverIndicator.AddComponent<RectTransform>();
            hoverIndicatorRectTransform.anchorMin = Vector2.zero;
            hoverIndicatorRectTransform.anchorMax = Vector2.one;
            hoverIndicatorRectTransform.offsetMin = new Vector2(-15.2858f, -15.0948f);
            hoverIndicatorRectTransform.offsetMax = new Vector2(15.2858f, 15.0948f);
            Image hoverIndicatorImage = HoverIndicator.AddComponent<Image>();
            hoverIndicatorImage.sprite = HUDButtonHover;
            hoverIndicatorImage.type = Image.Type.Sliced;
            hoverIndicatorImage.raycastPadding = Vector4.zero;
            hoverIndicatorImage.raycastTarget = false;
            hoverIndicatorImage.pixelsPerUnitMultiplier = 1.2f;
            CanvasGroup hoverIndicatorCanvasGroup = HoverIndicator.AddComponent<CanvasGroup>();
            hoverIndicatorCanvasGroup.alpha = 0;
            hoverIndicatorCanvasGroup.blocksRaycasts = false;
            hoverIndicatorCanvasGroup.ignoreParentGroups = false;
            hoverIndicatorCanvasGroup.interactable = false;
            GameObject Text = new GameObject("Text");
            Text.transform.SetParent(Button.transform);
            Text.layer = LayerMask.NameToLayer("UI");
            RectTransform textRectTransform = Text.AddComponent<RectTransform>();
            textRectTransform.anchorMin = Vector2.zero;
            textRectTransform.anchorMax = Vector2.one;
            textRectTransform.offsetMin = new Vector2(10.307f, 0);
            textRectTransform.offsetMax = new Vector2(-10.307f, 0);
            TextMeshProUGUI textTMP = Text.AddComponent<TextMeshProUGUI>();
            SetupPrimaryText(textTMP);
            HUDLocalizedText hudLocalizedText = Text.AddComponent<HUDLocalizedText>();
            hudLocalizedText.UIText = textTMP;
            Button buttonButton = Button.AddComponent<Button>();
            buttonButton.image = bgImage;
            HUDButton hudButton = Button.AddComponent<HUDButton>();
            hudButton.UIButton = buttonButton;
            hudButton.UIText = hudLocalizedText;
            hudButton.UIMainGroup = canvasGroup;
            hudButton.UIHoverIndicatorGroup = hoverIndicatorCanvasGroup;
            hudButton.UIMainTransform = rectTransform;
            hudButton.ChildComponentReferences = new HUDComponent[] { hudLocalizedText };
            return hudButton;
        }
        private static HUDAnimatedRoundButton CreateAnimatedRoundButton()
        {
            GameObject AnimatedRoundButton = new GameObject("AnimatedRoundButton");
            GameObject.DontDestroyOnLoad(AnimatedRoundButton);
            AnimatedRoundButton.SetActiveSelfExt(false);
            AnimatedRoundButton.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = AnimatedRoundButton.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            GameObject Bg = new GameObject("Bg");
            Bg.transform.SetParent(AnimatedRoundButton.transform);
            Bg.layer = LayerMask.NameToLayer("UI");
            RectTransform bgRectTransform = Bg.AddComponent<RectTransform>();
            bgRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            bgRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            bgRectTransform.offsetMin = new Vector2(-23.5f, -23.5f);
            bgRectTransform.offsetMax = new Vector2(23.5f, 23.5f);
            UniformModifier uniformModifier = Bg.AddComponent<UniformModifier>();
            ProceduralImage proceduralImage = Bg.AddComponent<ProceduralImage>();
            proceduralImage.color = Color.black;
            uniformModifier.Radius = 12;
            GameObject Icon = new GameObject("Icon");
            Icon.transform.SetParent(AnimatedRoundButton.transform);
            Icon.layer = LayerMask.NameToLayer("UI");
            RectTransform iconRectTransform = Icon.AddComponent<RectTransform>();
            iconRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            iconRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            iconRectTransform.offsetMin = new Vector2(-12f, -12f);
            iconRectTransform.offsetMax = new Vector2(12f, 12f);
            Image iconImage = Icon.AddComponent<Image>();
            iconImage.material = UISpriteWithMipMapBiasOverride;
            iconImage.color = new Color(1, 1, 1, 0.502f);
            Button animatedRoundButtonButton = AnimatedRoundButton.AddComponent<Button>();
            animatedRoundButtonButton.image = proceduralImage;
            animatedRoundButtonButton.transition = Selectable.Transition.ColorTint;
            animatedRoundButtonButton.colors = new ColorBlock()
            {
                normalColor = new Color(1, 1, 1, 0.2314f),
                highlightedColor = new Color(1, 1, 1, 0.502f),
                pressedColor = new Color(1, 1, 1, 0.502f),
                selectedColor = new Color(0.9608f, 0.9608f, 0.9608f, 0.502f),
                disabledColor = new Color(1, 1, 1, 0.4745f),
                colorMultiplier = 1,
                fadeDuration = 0.1f
            };
            HUDAnimatedRoundButton hudAnimatedRoundButton = AnimatedRoundButton.AddComponent<HUDAnimatedRoundButton>();
            hudAnimatedRoundButton.UIButton = animatedRoundButtonButton;
            hudAnimatedRoundButton.UIIconTransform = iconRectTransform;
            hudAnimatedRoundButton.UIMainIcon = iconImage;
            return hudAnimatedRoundButton;
        }
        private static HUDIconButton CreateIconButton()
        {
            GameObject IconButton = new GameObject("IconButton");
            GameObject.DontDestroyOnLoad(IconButton);
            IconButton.SetActiveSelfExt(false);
            IconButton.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = IconButton.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            CanvasGroup canvasGroup = IconButton.AddComponent<CanvasGroup>();
            GameObject BaseBg = new GameObject("BaseBg");
            BaseBg.transform.SetParent(IconButton.transform);
            BaseBg.layer = LayerMask.NameToLayer("UI");
            RectTransform baseBgRectTransform = BaseBg.AddComponent<RectTransform>();
            baseBgRectTransform.anchorMin = new Vector2(0f, 0f);
            baseBgRectTransform.anchorMax = new Vector2(1f, 1f);
            baseBgRectTransform.offsetMin = new Vector2(-14.2274f, -14.2276f);
            baseBgRectTransform.offsetMax = new Vector2(14.2274f, 14.2276f);
            Image baseBgImage = BaseBg.AddComponent<Image>();
            baseBgImage.material = UIAnimatedButtonBaseMaterial;
            baseBgImage.sprite = HUDIconButtonBase;
            baseBgImage.type = Image.Type.Sliced;
            baseBgImage.raycastTarget = false;
            GameObject highlight = new GameObject("Highlight");
            highlight.transform.SetParent(IconButton.transform);
            highlight.layer = LayerMask.NameToLayer("UI");
            RectTransform highlightRectTransform = highlight.AddComponent<RectTransform>();
            highlightRectTransform.anchorMin = new Vector2(0f, 0f);
            highlightRectTransform.anchorMax = new Vector2(1f, 1f);
            highlightRectTransform.offsetMin = new Vector2(-17.119f, -17.119f);
            highlightRectTransform.offsetMax = new Vector2(17.119f, 17.119f);
            CanvasGroup highlightCanvasGroup = highlight.AddComponent<CanvasGroup>();
            highlightCanvasGroup.blocksRaycasts = false;
            highlightCanvasGroup.interactable = false;
            Image highlightImage = highlight.AddComponent<Image>();
            highlightImage.material = UIAnimatedHighlightMaterial;
            highlightImage.sprite = HUDPanelHighlightFG;
            highlightImage.type = Image.Type.Sliced;
            highlightImage.raycastTarget = false;
            GameObject hoverBg = new GameObject("HoverBg");
            hoverBg.transform.SetParent(IconButton.transform);
            hoverBg.layer = LayerMask.NameToLayer("UI");
            RectTransform hoverBgRectTransform = hoverBg.AddComponent<RectTransform>();
            hoverBgRectTransform.anchorMin = new Vector2(0f, 0f);
            hoverBgRectTransform.anchorMax = new Vector2(1f, 1f);
            hoverBgRectTransform.offsetMin = new Vector2(-14.2274f, -14.2274f);
            hoverBgRectTransform.offsetMax = new Vector2(14.2274f, 14.2274f);
            CanvasGroup hoverBgCanvasGroup = hoverBg.AddComponent<CanvasGroup>();
            hoverBgCanvasGroup.blocksRaycasts = false;
            hoverBgCanvasGroup.interactable = false;
            Image hoverBgImage = hoverBg.AddComponent<Image>();
            hoverBgImage.material = UIAnimatedButtonBaseMaterial;
            hoverBgImage.sprite = HUDIconButtonHover;
            hoverBgImage.type = Image.Type.Sliced;
            hoverBgImage.raycastTarget = false;
            GameObject activeBg = new GameObject("ActiveBg");
            activeBg.transform.SetParent(IconButton.transform);
            activeBg.layer = LayerMask.NameToLayer("UI");
            RectTransform activeBgRectTransform = activeBg.AddComponent<RectTransform>();
            activeBgRectTransform.anchorMin = new Vector2(0f, 0f);
            activeBgRectTransform.anchorMax = new Vector2(1f, 1f);
            activeBgRectTransform.offsetMin = new Vector2(-14.2274f, -14.2274f);
            activeBgRectTransform.offsetMax = new Vector2(14.2274f, 14.2274f);
            CanvasGroup activeBgCanvasGroup = activeBg.AddComponent<CanvasGroup>();
            activeBgCanvasGroup.alpha = 0f;
            activeBgCanvasGroup.blocksRaycasts = false;
            activeBgCanvasGroup.interactable = false;
            Image activeBgImage = activeBg.AddComponent<Image>();
            activeBgImage.material = UIAnimatedButtonBaseMaterial;
            activeBgImage.sprite = HUDIconButtonActive;
            activeBgImage.type = Image.Type.Sliced;
            activeBgImage.raycastTarget = false;
            activeBg.SetActiveSelfExt(false);
            GameObject icon = new GameObject("Icon");
            icon.transform.SetParent(IconButton.transform);
            icon.layer = LayerMask.NameToLayer("UI");
            RectTransform iconRectTransform = icon.AddComponent<RectTransform>();
            iconRectTransform.anchorMin = new Vector2(0f, 0f);
            iconRectTransform.anchorMax = new Vector2(1f, 1f);
            iconRectTransform.offsetMin = new Vector2(6, 6);
            iconRectTransform.offsetMax = new Vector2(-6, -6);
            Image iconImage = icon.AddComponent<Image>();
            iconImage.material = UIAnimatedIconMaterial;
            iconImage.color = new Color(1, 1, 1, 0.75f);
            iconImage.raycastPadding = new Vector4(-14, -14, -14, -14);
            HUDTooltipTarget hudTooltipTarget = icon.AddComponent<HUDTooltipTarget>();
            hudTooltipTarget.Keybinding = "";
            hudTooltipTarget.enabled = false;
            GameObject hudBadgeGO = new GameObject("HUDBadge");
            hudBadgeGO.transform.SetParent(IconButton.transform);
            hudBadgeGO.layer = LayerMask.NameToLayer("UI");
            RectTransform hudBadgeRectTransform = hudBadgeGO.AddComponent<RectTransform>();
            hudBadgeRectTransform.anchorMin = Vector2.up;
            hudBadgeRectTransform.anchorMax = Vector2.up;
            hudBadgeRectTransform.offsetMin = new Vector2(-15.81f, -28.99f);
            hudBadgeRectTransform.offsetMax = new Vector2(29.19f, 16.01f);
            Image hudBadgeImage = hudBadgeGO.AddComponent<Image>();
            hudBadgeImage.material = UISpriteWithMipMapBiasOverride;
            hudBadgeImage.sprite = HUDSoloBadge;
            hudBadgeImage.raycastTarget = false;
            HUDBadge hudBadge = hudBadgeGO.AddComponent<HUDBadge>();
            hudBadge.Active = false;
            hudBadgeGO.SetActiveSelfExt(false);
            hudBadge.UIBadgeTransform = hudBadgeRectTransform;
            Button button = IconButton.AddComponent<Button>();
            button.image = iconImage;
            button.transition = Selectable.Transition.None;
            HUDIconButton hudIconButton = IconButton.AddComponent<HUDIconButton>();
            hudIconButton.UIActiveGroup = activeBgCanvasGroup;
            hudIconButton.UIBadge = hudBadge;
            hudIconButton.UIButton = button;
            hudIconButton.UIHighlightGroup = highlightCanvasGroup;
            hudIconButton.UIHoverIndicatorGroup = hoverBgCanvasGroup;
            hudIconButton.UIIcon = iconImage;
            hudIconButton.UIMainGroup = canvasGroup;
            hudIconButton.UIMainTransform = rectTransform;
            hudIconButton.UITooltipTarget = hudTooltipTarget;
            hudIconButton.TooltipAlignment = HUDTooltip.TooltipAlignment.Left_Middle;
            hudIconButton.TooltipKeybinding = "";
            hudIconButton.HasTooltip = false;
            hudIconButton.ChildComponentReferences = new HUDComponent[] { hudBadge };
            return hudIconButton;
        }
        private static TextMeshProUGUI CreateTextPrimary()
        {
            GameObject Text = new GameObject("Text");
            GameObject.DontDestroyOnLoad(Text);
            Text.SetActiveSelfExt(false);
            Text.layer = LayerMask.NameToLayer("UI");
            TextMeshProUGUI textTMP = Text.AddComponent<TextMeshProUGUI>();
            SetupPrimaryText(textTMP);
            return textTMP;
        }
        private static TextMeshProUGUI CreateTextSecondary()
        {
            GameObject Text = new GameObject("Text");
            GameObject.DontDestroyOnLoad(Text);
            Text.SetActiveSelfExt(false);
            Text.layer = LayerMask.NameToLayer("UI");
            TextMeshProUGUI textTMP = Text.AddComponent<TextMeshProUGUI>();
            SetupSecondaryText(textTMP);
            return textTMP;
        }
        private static HUDLocalizedText CreateLocalizedTextPrimary()
        {
            GameObject Text = new GameObject("Text");
            GameObject.DontDestroyOnLoad(Text);
            Text.SetActiveSelfExt(false);
            Text.layer = LayerMask.NameToLayer("UI");
            TextMeshProUGUI textTMP = Text.AddComponent<TextMeshProUGUI>();
            SetupPrimaryText(textTMP);
            HUDLocalizedText hudLocalizedText = Text.AddComponent<HUDLocalizedText>();
            hudLocalizedText.UIText = textTMP;
            return hudLocalizedText;
        }
        private static HUDLocalizedText CreateLocalizedTextSecondary()
        {
            GameObject Text = new GameObject("Text");
            GameObject.DontDestroyOnLoad(Text);
            Text.SetActiveSelfExt(false);
            Text.layer = LayerMask.NameToLayer("UI");
            TextMeshProUGUI textTMP = Text.AddComponent<TextMeshProUGUI>();
            SetupSecondaryText(textTMP);
            HUDLocalizedText hudLocalizedText = Text.AddComponent<HUDLocalizedText>();
            hudLocalizedText.UIText = textTMP;
            return hudLocalizedText;
        }
        private static HUDInputField CreateInputField()
        {
            GameObject InputField = new GameObject("InputField");
            GameObject.DontDestroyOnLoad(InputField);
            InputField.SetActiveSelfExt(false);
            InputField.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = InputField.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            TMP_InputField tmp_InputField = InputField.AddComponent<TMP_InputField>();
            UniformModifier uniformModifier = InputField.AddComponent<UniformModifier>();
            ProceduralImage proceduralImage = InputField.AddComponent<ProceduralImage>();
            tmp_InputField.image = proceduralImage;
            uniformModifier.Radius = 12;
            GameObject TextArea = new GameObject("Text Area");
            TextArea.transform.SetParent(InputField.transform);
            TextArea.layer = LayerMask.NameToLayer("UI");
            RectTransform TextAreaRectTransform = TextArea.AddComponent<RectTransform>();
            TextAreaRectTransform.anchorMin = Vector2.zero;
            TextAreaRectTransform.anchorMax = Vector2.one;
            TextAreaRectTransform.offsetMin = new Vector2(10, 6);
            TextAreaRectTransform.offsetMax = new Vector2(-10, -7);
            TextAreaRectTransform.anchoredPosition = new Vector2(0, -0.5f);
            RectMask2D rectMask2D = TextArea.AddComponent<RectMask2D>();
            rectMask2D.padding = new Vector4(-8, -5, -8, -5);
            GameObject Placeholder = new GameObject("Placeholder");
            Placeholder.transform.SetParent(TextArea.transform);
            Placeholder.layer = LayerMask.NameToLayer("UI");
            RectTransform placeholderRectTransform = Placeholder.AddComponent<RectTransform>();
            placeholderRectTransform.anchorMin = Vector2.zero;
            placeholderRectTransform.anchorMax = Vector2.one;
            placeholderRectTransform.offsetMin = Vector2.zero;
            placeholderRectTransform.offsetMax = Vector2.zero;
            LayoutElement PlaceholderLayoutElement = Placeholder.AddComponent<LayoutElement>();
            PlaceholderLayoutElement.ignoreLayout = true;
            TextMeshProUGUI placeholderTextMeshProUGUI = Placeholder.AddComponent<TextMeshProUGUI>();
            tmp_InputField.placeholder = placeholderTextMeshProUGUI;
            placeholderTextMeshProUGUI.alignment = TextAlignmentOptions.Left;
            placeholderTextMeshProUGUI.color = new Color(1, 1, 1, 0.098f);
            placeholderTextMeshProUGUI.extraPadding = true;
            placeholderTextMeshProUGUI.fontFeatures = new List<UnityEngine.TextCore.OTL_FeatureTag> { UnityEngine.TextCore.OTL_FeatureTag.kern };
            placeholderTextMeshProUGUI.font = FontLightSDF;
            placeholderTextMeshProUGUI.fontSize = 20;
            placeholderTextMeshProUGUI.fontSizeMax = 72;
            placeholderTextMeshProUGUI.fontSizeMin = 18;
            placeholderTextMeshProUGUI.isOrthographic = true;
            HUDLocalizedText hudLocalizedText = Placeholder.AddComponent<HUDLocalizedText>();
            hudLocalizedText.UIText = placeholderTextMeshProUGUI;
            GameObject Text = new GameObject("Text");
            Text.transform.SetParent(TextArea.transform);
            Text.layer = LayerMask.NameToLayer("UI");
            RectTransform textRectTransform = Text.AddComponent<RectTransform>();
            textRectTransform.anchorMin = Vector2.zero;
            textRectTransform.anchorMax = Vector2.one;
            textRectTransform.offsetMin = Vector2.zero;
            textRectTransform.offsetMax = Vector2.zero;
            TextMeshProUGUI TextMeshProUGUI = Text.AddComponent<TextMeshProUGUI>();
            tmp_InputField.textComponent = TextMeshProUGUI;
            TextMeshProUGUI.alignment = TextAlignmentOptions.Left;
            TextMeshProUGUI.extraPadding = true;
            TextMeshProUGUI.fontFeatures = new List<UnityEngine.TextCore.OTL_FeatureTag> { UnityEngine.TextCore.OTL_FeatureTag.kern };
            TextMeshProUGUI.font = FontLightSDF;
            TextMeshProUGUI.fontSize = 20;
            TextMeshProUGUI.fontSizeMax = 72;
            TextMeshProUGUI.fontSizeMin = 18;
            TextMeshProUGUI.isOrthographic = true;
            tmp_InputField.textViewport = TextAreaRectTransform;
            GameObject Border = new GameObject("Border");
            Border.transform.SetParent(InputField.transform);
            Border.layer = LayerMask.NameToLayer("UI");
            RectTransform borderRectTransform = Border.AddComponent<RectTransform>();
            borderRectTransform.anchorMin = Vector2.zero;
            borderRectTransform.anchorMax = Vector2.one;
            borderRectTransform.offsetMin = Vector2.zero;
            borderRectTransform.offsetMax = Vector2.zero;
            UniformModifier borderUniformModifier = Border.AddComponent<UniformModifier>();
            ProceduralImage borderProceduralImage = Border.AddComponent<ProceduralImage>();
            borderProceduralImage.BorderWidth = 1.5f;
            borderProceduralImage.color = new Color(1, 1, 1, 0.0314f);
            borderProceduralImage.raycastTarget = false;
            borderUniformModifier.Radius = 12;
            tmp_InputField.characterLimit = 128;
            tmp_InputField.characterValidation = TMP_InputField.CharacterValidation.Regex;
            tmp_InputField.contentType = TMP_InputField.ContentType.Custom;
            tmp_InputField.fontAsset = FontLightSDF;
            tmp_InputField.keyboardType = TouchScreenKeyboardType.ASCIICapable;
            tmp_InputField.pointSize = 20;
            tmp_InputField.richText = false;
            tmp_InputField.selectionColor = new Color(1, 0.6167f, 0, 0.9686f);
            tmp_InputField.colors = new ColorBlock()
            {
                colorMultiplier = 1,
                disabledColor = new Color(0, 0, 0, 0.0314f),
                fadeDuration = 0.1f,
                highlightedColor = new Color(0, 0, 0, 0.549f),
                normalColor = new Color(0, 0, 0, 0.349f),
                pressedColor = new Color(0, 0, 0, 0.549f),
                selectedColor = new Color(0, 0, 0, 0.451f)
            };
            tmp_InputField.m_RegexValue = "^([^\\n\\r])$";
            HUDInputField hudInputField = InputField.AddComponent<HUDInputField>();
            hudInputField.UIInputField = tmp_InputField;
            hudInputField.UIPlaceholderText = hudLocalizedText;
            hudInputField.ChildComponentReferences = new HUDComponent[] { hudLocalizedText };
            return hudInputField;
        }
        private static HUDScrollContainer CreateScrollContainer()
        {
            GameObject ScrollContainer = new GameObject("ScrollContainer");
            GameObject.DontDestroyOnLoad(ScrollContainer);
            ScrollContainer.SetActiveSelfExt(false);
            ScrollContainer.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = ScrollContainer.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            ScrollRect scrollRect = ScrollContainer.AddComponent<ScrollRect>();
            GameObject Viewport = new GameObject("Viewport");
            Viewport.transform.SetParent(ScrollContainer.transform);
            Viewport.layer = LayerMask.NameToLayer("UI");
            RectTransform viewportRectTransform = Viewport.AddComponent<RectTransform>();
            viewportRectTransform.pivot = Vector2.up;
            viewportRectTransform.anchorMin = Vector2.zero;
            viewportRectTransform.anchorMax = Vector2.one;
            viewportRectTransform.offsetMin = Vector2.zero;
            viewportRectTransform.offsetMax = Vector2.zero;
            Image viewportImage = Viewport.AddComponent<Image>();
            viewportImage.sprite = HUDPrimaryLightPanelMask;
            viewportImage.type = Image.Type.Sliced;
            Mask viewportMask = Viewport.AddComponent<Mask>();
            viewportMask.showMaskGraphic = false;
            GameObject Content = new GameObject("Content");
            Content.transform.SetParent(Viewport.transform);
            Content.layer = LayerMask.NameToLayer("UI");
            RectTransform contentRectTransform = Content.AddComponent<RectTransform>();
            contentRectTransform.pivot = Vector2.up;
            contentRectTransform.anchorMin = Vector2.up;
            contentRectTransform.anchorMax = Vector2.one;
            contentRectTransform.offsetMin = new Vector2(0, -50);
            contentRectTransform.offsetMax = Vector2.zero;
            // Add graphicraycaster to Content after Instantiated with blockingMask 55
            VerticalLayoutGroup contentVerticalLayoutGroup = Content.AddComponent<VerticalLayoutGroup>();
            contentVerticalLayoutGroup.childScaleHeight = true;
            contentVerticalLayoutGroup.childScaleWidth = true;
            contentVerticalLayoutGroup.spacing = 10;
            contentVerticalLayoutGroup.padding = new RectOffset(25, 25, 25, 25);
            ContentSizeFitter contentContentSizeFitter = Content.AddComponent<ContentSizeFitter>();
            contentContentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            GameObject ScrollbarHorizontal = new GameObject("Scrollbar Horizontal");
            ScrollbarHorizontal.transform.SetParent(ScrollContainer.transform);
            ScrollbarHorizontal.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarHorizontalRectTransform = ScrollbarHorizontal.AddComponent<RectTransform>();
            Image scrollbarHorizontalImage = ScrollbarHorizontal.AddComponent<Image>();
            scrollbarHorizontalImage.type = Image.Type.Sliced;
            scrollbarHorizontalImage.color = Color.clear;
            GameObject ScrollbarHorizontalSlidingArea = new GameObject("Sliding Area");
            ScrollbarHorizontalSlidingArea.transform.SetParent(ScrollbarHorizontal.transform);
            ScrollbarHorizontalSlidingArea.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarHorizontalSlidingAreaRectTransform = ScrollbarHorizontalSlidingArea.AddComponent<RectTransform>();
            GameObject ScrollbarHorizontalHandle = new GameObject("Handle");
            ScrollbarHorizontalHandle.transform.SetParent(ScrollbarHorizontalSlidingArea.transform);
            ScrollbarHorizontalHandle.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarHorizontalHandleRectTransform = ScrollbarHorizontalHandle.AddComponent<RectTransform>();
            scrollbarHorizontalHandleRectTransform.anchorMin = Vector2.zero;
            scrollbarHorizontalHandleRectTransform.anchorMax = Vector2.one;
            scrollbarHorizontalHandleRectTransform.offsetMin = new Vector2(-3, -3);
            scrollbarHorizontalHandleRectTransform.offsetMax = new Vector2(3, 3);
            Image scrollbarHorizontalHandleImage = ScrollbarHorizontalHandle.AddComponent<Image>();
            scrollbarHorizontalHandleImage.sprite = HUDScrollbarPanelBg;
            scrollbarHorizontalHandleImage.type = Image.Type.Sliced;
            scrollbarHorizontalHandleImage.pixelsPerUnitMultiplier = 7;
            scrollbarHorizontalHandleImage.raycastPadding = new Vector4(-5, -5, -5, -5);
            Scrollbar scrollbarHorizontalScrollbar = ScrollbarHorizontal.AddComponent<Scrollbar>();
            scrollbarHorizontalScrollbar.handleRect = scrollbarHorizontalHandleRectTransform;
            scrollbarHorizontalScrollbar.targetGraphic = scrollbarHorizontalHandleImage;
            scrollbarHorizontalScrollbar.colors = new ColorBlock()
            {
                normalColor = new Color(0.9198f, 0.9236f, 1, 0.0353f),
                highlightedColor = new Color(0.9216f, 0.9255f, 1, 0.1059f),
                pressedColor = new Color(0.9216f, 0.9255f, 1, 0.1647f),
                selectedColor = new Color(0.9216f, 0.9255f, 1, 0.149f),
                disabledColor = new Color(0.9216f, 0.9255f, 1, 0.0078f),
                colorMultiplier = 1,
                fadeDuration = 0.2f
            };
            GameObject ScrollbarVertical = new GameObject("Scrollbar Vertical");
            ScrollbarVertical.transform.SetParent(ScrollContainer.transform);
            ScrollbarVertical.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarVerticalRectTransform = ScrollbarVertical.AddComponent<RectTransform>();
            Image scrollbarVerticalImage = ScrollbarVertical.AddComponent<Image>();
            scrollbarVerticalImage.type = Image.Type.Sliced;
            scrollbarVerticalImage.color = Color.clear;
            GameObject ScrollbarVerticalSlidingArea = new GameObject("Sliding Area");
            ScrollbarVerticalSlidingArea.transform.SetParent(ScrollbarVertical.transform);
            ScrollbarVerticalSlidingArea.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarVerticalSlidingAreaRectTransform = ScrollbarVerticalSlidingArea.AddComponent<RectTransform>();
            GameObject ScrollbarVerticalHandle = new GameObject("Handle");
            ScrollbarVerticalHandle.transform.SetParent(ScrollbarVerticalSlidingArea.transform);
            ScrollbarVerticalHandle.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarVerticalHandleRectTransform = ScrollbarVerticalHandle.AddComponent<RectTransform>();
            scrollbarVerticalHandleRectTransform.anchorMin = Vector2.zero;
            scrollbarVerticalHandleRectTransform.anchorMax = Vector2.one;
            scrollbarVerticalHandleRectTransform.offsetMin = new Vector2(-3, -3);
            scrollbarVerticalHandleRectTransform.offsetMax = new Vector2(3, 3);
            Image scrollbarVerticalHandleImage = ScrollbarVerticalHandle.AddComponent<Image>();
            scrollbarVerticalHandleImage.sprite = HUDScrollbarPanelBg;
            scrollbarVerticalHandleImage.type = Image.Type.Sliced;
            scrollbarVerticalHandleImage.pixelsPerUnitMultiplier = 7;
            scrollbarVerticalHandleImage.raycastPadding = new Vector4(-5, -5, -5, -5);
            Scrollbar scrollbarVerticalScrollbar = ScrollbarVertical.AddComponent<Scrollbar>();
            scrollbarVerticalScrollbar.handleRect = scrollbarVerticalHandleRectTransform;
            scrollbarVerticalScrollbar.targetGraphic = scrollbarVerticalHandleImage;
            scrollbarVerticalScrollbar.SetDirection(Scrollbar.Direction.BottomToTop, true);
            scrollbarVerticalScrollbar.colors = new ColorBlock()
            {
                normalColor = new Color(0.9198f, 0.9236f, 1, 0.0353f),
                highlightedColor = new Color(0.9216f, 0.9255f, 1, 0.1059f),
                pressedColor = new Color(0.9216f, 0.9255f, 1, 0.1647f),
                selectedColor = new Color(0.9216f, 0.9255f, 1, 0.149f),
                disabledColor = new Color(0.9216f, 0.9255f, 1, 0.0078f),
                colorMultiplier = 1,
                fadeDuration = 0.2f
            };
            scrollRect.content = contentRectTransform;
            scrollRect.viewport = viewportRectTransform;
            scrollRect.horizontalScrollbar = scrollbarHorizontalScrollbar;
            scrollRect.verticalScrollbar = scrollbarVerticalScrollbar;
            scrollRect.horizontalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            scrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            scrollRect.horizontalScrollbarSpacing = -3f;
            scrollRect.verticalScrollbarSpacing = -3f;
            scrollRect.decelerationRate = 0.01f;
            scrollRect.movementType = ScrollRect.MovementType.Clamped;
            scrollRect.normalizedPosition = Vector2.right;
            scrollbarHorizontalRectTransform.pivot = Vector2.zero;
            scrollbarHorizontalRectTransform.anchorMin = Vector2.zero;
            scrollbarHorizontalRectTransform.anchorMax = Vector2.right;
            scrollbarHorizontalRectTransform.offsetMin = Vector2.zero;
            scrollbarHorizontalRectTransform.offsetMax = new Vector2(0, 20);
            scrollbarHorizontalSlidingAreaRectTransform.anchorMin = Vector2.zero;
            scrollbarHorizontalSlidingAreaRectTransform.anchorMax = Vector2.one;
            scrollbarHorizontalSlidingAreaRectTransform.anchoredPosition = new Vector2(0, 2.5f);
            scrollbarHorizontalSlidingAreaRectTransform.sizeDelta = new Vector2(-60, -15);
            scrollbarVerticalRectTransform.pivot = Vector2.one;
            scrollbarVerticalRectTransform.anchorMin = Vector2.right;
            scrollbarVerticalRectTransform.anchorMax = Vector2.one;
            scrollbarVerticalRectTransform.offsetMin = new Vector2(-20, 0);
            scrollbarVerticalRectTransform.offsetMax = Vector2.zero;
            scrollbarVerticalSlidingAreaRectTransform.anchorMin = Vector2.zero;
            scrollbarVerticalSlidingAreaRectTransform.anchorMax = Vector2.one;
            scrollbarVerticalSlidingAreaRectTransform.anchoredPosition = new Vector2(-2.5f, 0);
            scrollbarVerticalSlidingAreaRectTransform.sizeDelta = new Vector2(-15, -60);
            HUDScrollContainer hudScrollContainer = ScrollContainer.AddComponent<HUDScrollContainer>();
            hudScrollContainer.UIScrollRect = scrollRect;
            return hudScrollContainer;
        }
        private static GameObject CreateDivider()
        {
            GameObject Divider = new GameObject("Divider");
            GameObject.DontDestroyOnLoad(Divider);
            Divider.SetActiveSelfExt(false);
            Divider.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = Divider.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.up;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = new Vector2(0, -2.5f);
            rectTransform.offsetMax = new Vector2(0, 1.5f);
            Image Image = Divider.AddComponent<Image>();
            Image.sprite = HUDAntiAliasedHorizontalScrollDivider;
            Image.material = UISpriteWithMipMapBiasOverride;
            Image.type = Image.Type.Sliced;
            Image.raycastTarget = false;
            return Divider;
        }
        private static HUDToggleControl CreateToggle()
        {
            GameObject ToggleControl = new GameObject("ToggleControl");
            GameObject.DontDestroyOnLoad(ToggleControl);
            ToggleControl.SetActiveSelfExt(false);
            ToggleControl.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = ToggleControl.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            CanvasGroup canvasGroup = ToggleControl.AddComponent<CanvasGroup>();
            GameObject Toggle = new GameObject("Toggle");
            Toggle.transform.SetParent(ToggleControl.transform);
            Toggle.layer = LayerMask.NameToLayer("UI");
            RectTransform toggleRectTransform = Toggle.AddComponent<RectTransform>();
            toggleRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            toggleRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            toggleRectTransform.sizeDelta = new Vector2(56.6763f, 28.3381f);
            GameObject OffBg = new GameObject("OffBg");
            OffBg.transform.SetParent(Toggle.transform);
            OffBg.layer = LayerMask.NameToLayer("UI");
            RectTransform offBgRectTransform = OffBg.AddComponent<RectTransform>();
            offBgRectTransform.anchorMin = Vector2.zero;
            offBgRectTransform.anchorMax = Vector2.one;
            offBgRectTransform.offsetMin = Vector2.zero;
            offBgRectTransform.offsetMax = Vector2.zero;
            CanvasGroup offBgCanvasGroup = OffBg.AddComponent<CanvasGroup>();
            RoundModifier offBgRoundModifier = OffBg.AddComponent<RoundModifier>();
            ProceduralImage offBgProceduralImage = OffBg.AddComponent<ProceduralImage>();
            offBgProceduralImage.BorderWidth = 1f;
            offBgProceduralImage.color = new Color(1, 1, 1, 0.102f);
            offBgProceduralImage.raycastTarget = false;
            GameObject OnBg = new GameObject("OnBg");
            OnBg.transform.SetParent(Toggle.transform);
            OnBg.layer = LayerMask.NameToLayer("UI");
            RectTransform onBgRectTransform = OnBg.AddComponent<RectTransform>();
            onBgRectTransform.anchorMin = Vector2.zero;
            onBgRectTransform.anchorMax = Vector2.one;
            onBgRectTransform.offsetMin = new Vector2(-14.1813f, -13.9243f);
            onBgRectTransform.offsetMax = new Vector2(14.1813f, 13.9243f);
            CanvasGroup onBgCanvasGroup = OnBg.AddComponent<CanvasGroup>();
            Image onBgImage = OnBg.AddComponent<Image>();
            onBgImage.material = UIAnimatedIconMaterial;
            onBgImage.sprite = HUDIconButtonHighlight;
            onBgImage.pixelsPerUnitMultiplier = 0.95f;
            onBgImage.type = Image.Type.Sliced;
            onBgImage.color = new Color(1, 1, 1, 0.7216f);
            onBgImage.raycastTarget = false;
            GameObject HoverBg = new GameObject("HoverBg");
            HoverBg.transform.SetParent(Toggle.transform);
            HoverBg.layer = LayerMask.NameToLayer("UI");
            RectTransform hoverBgRectTransform = HoverBg.AddComponent<RectTransform>();
            hoverBgRectTransform.anchorMin = Vector2.zero;
            hoverBgRectTransform.anchorMax = Vector2.one;
            hoverBgRectTransform.offsetMin = new Vector2(-6, -6);
            hoverBgRectTransform.offsetMax = new Vector2(6, 6);
            RoundModifier hoverBgRoundModifier = HoverBg.AddComponent<RoundModifier>();
            ProceduralImage hoverBgProceduralImage = HoverBg.AddComponent<ProceduralImage>();
            hoverBgProceduralImage.BorderWidth = 0;
            hoverBgProceduralImage.color = new Color(0, 0, 0, 1);
            hoverBgProceduralImage.raycastPadding = new Vector4(-5, -5, -5, -5);
            GameObject Knob = new GameObject("Knob");
            Knob.transform.SetParent(Toggle.transform);
            Knob.layer = LayerMask.NameToLayer("UI");
            RectTransform knobRectTransform = Knob.AddComponent<RectTransform>();
            knobRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            knobRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            knobRectTransform.offsetMin = new Vector2(-24, -10);
            knobRectTransform.offsetMax = new Vector2(-4, 10);
            RoundModifier knobRoundModifier = Knob.AddComponent<RoundModifier>();
            ProceduralImage knobProceduralImage = Knob.AddComponent<ProceduralImage>();
            knobProceduralImage.BorderWidth = 0;
            knobProceduralImage.color = new Color(1, 1, 1, 1);
            knobProceduralImage.raycastPadding = new Vector4(0, 0, 0, 0);
            Button button = Toggle.AddComponent<Button>();
            button.image = hoverBgProceduralImage;
            button.colors = new ColorBlock()
            {
                normalColor = new Color(1, 1, 1, 0),
                highlightedColor = new Color(1, 1, 1, 0.349f),
                pressedColor = new Color(1, 1, 1, 0.651f),
                selectedColor = new Color(1, 1, 1, 0.651f),
                disabledColor = new Color(1, 1, 1, 0),
                colorMultiplier = 1,
                fadeDuration = 0.2f
            };
            HUDToggleControl hudToggleControl = ToggleControl.AddComponent<HUDToggleControl>();
            hudToggleControl.UIButton = button;
            hudToggleControl.UIKnobTransform = knobRectTransform;
            hudToggleControl.UIMainGroup = canvasGroup;
            hudToggleControl.UIOffIndicator = offBgCanvasGroup;
            hudToggleControl.UIOnIndicator = onBgCanvasGroup;
            return hudToggleControl;
        }
        private static HUDEnumSelectorControl CreateEnumSelector()
        {
            GameObject EnumSelectorControl = new GameObject("EnumSelectorControl");
            GameObject.DontDestroyOnLoad(EnumSelectorControl);
            EnumSelectorControl.SetActiveSelfExt(false);
            EnumSelectorControl.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = EnumSelectorControl.AddComponent<RectTransform>();
            //rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            //rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            //rectTransform.offsetMin = new Vector2(-125, -25);
            //rectTransform.offsetMax = new Vector2(125, 25);
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            HUDEnumSelectorControl hudEnumSelectorControl = EnumSelectorControl.AddComponent<HUDEnumSelectorControl>();
            var hudDropdownControl = AddDropdown(rectTransform, hudEnumSelectorControl);
            RectTransform hudDropdownControlRectTransform = hudDropdownControl.gameObject.GetComponent<RectTransform>();
            //hudDropdownControlRectTransform.anchorMin = new Vector2(0, 0.5f);
            //hudDropdownControlRectTransform.anchorMax = new Vector2(1, 0.5f);
            //hudDropdownControlRectTransform.offsetMin = new Vector2(0, -22.5f);
            //hudDropdownControlRectTransform.offsetMax = new Vector2(0, 22.5f);
            hudDropdownControlRectTransform.anchorMin = Vector2.zero;
            hudDropdownControlRectTransform.anchorMax = Vector2.one;
            hudDropdownControlRectTransform.offsetMin = Vector2.zero;
            hudDropdownControlRectTransform.offsetMax = Vector2.zero;
            LayoutElement hudDropdownControlLayoutElement = hudDropdownControl.gameObject.AddComponent<LayoutElement>();
            hudDropdownControlLayoutElement.minHeight = 50;
            hudDropdownControlLayoutElement.preferredHeight = 50;
            hudEnumSelectorControl.UIDropdown = hudDropdownControl;
            return hudEnumSelectorControl;
        }
        private static HUDDropdownControl CreateDropdown()
        {
            GameObject Dropdown = new GameObject("Dropdown");
            GameObject.DontDestroyOnLoad(Dropdown);
            Dropdown.SetActiveSelfExt(false);
            Dropdown.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = Dropdown.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            CanvasGroup canvasGroup = Dropdown.AddComponent<CanvasGroup>();
            GameObject BaseImage = new GameObject("BaseImage");
            BaseImage.transform.SetParent(Dropdown.transform);
            BaseImage.layer = LayerMask.NameToLayer("UI");
            RectTransform baseImageRectTransform = BaseImage.AddComponent<RectTransform>();
            baseImageRectTransform.anchorMin = Vector2.zero;
            baseImageRectTransform.anchorMax = Vector2.one;
            baseImageRectTransform.offsetMin = new Vector2(-13.906f, -14.3569f);
            baseImageRectTransform.offsetMax = new Vector2(13.906f, 14.3569f);
            Image baseImageImage = BaseImage.AddComponent<Image>();
            baseImageImage.material = UIAnimatedIconButtonMaterial;
            baseImageImage.sprite = HUDPanelButtonBase;
            baseImageImage.type = Image.Type.Sliced;
            baseImageImage.raycastTarget = false;
            GameObject HoverImage = new GameObject("HoverImage");
            HoverImage.transform.SetParent(Dropdown.transform);
            HoverImage.layer = LayerMask.NameToLayer("UI");
            RectTransform hoverImageRectTransform = HoverImage.AddComponent<RectTransform>();
            hoverImageRectTransform.anchorMin = Vector2.zero;
            hoverImageRectTransform.anchorMax = Vector2.one;
            hoverImageRectTransform.offsetMin = new Vector2(-13.906f, -14.3569f);
            hoverImageRectTransform.offsetMax = new Vector2(13.906f, 14.3569f);
            Image hoverImageImage = HoverImage.AddComponent<Image>();
            hoverImageImage.material = UISpriteWithMipMapBiasOverride;
            hoverImageImage.sprite = HUDIconButtonHover;
            hoverImageImage.type = Image.Type.Sliced;
            hoverImageImage.raycastPadding = new Vector4(15, 15, 15, 15);
            GameObject DropdownIndicator = new GameObject("DropdownIndicator");
            DropdownIndicator.transform.SetParent(Dropdown.transform);
            DropdownIndicator.layer = LayerMask.NameToLayer("UI");
            RectTransform dropdownIndicatorRectTransform = DropdownIndicator.AddComponent<RectTransform>();
            dropdownIndicatorRectTransform.anchorMin = new Vector2(1, 0.5f);
            dropdownIndicatorRectTransform.anchorMax = new Vector2(1, 0.5f);
            dropdownIndicatorRectTransform.offsetMin = new Vector2(-20.2452f, -6.5642f);
            dropdownIndicatorRectTransform.offsetMax = new Vector2(-8.1169f, 5.5642f);
            Image dropdownIndicatorImage = DropdownIndicator.AddComponent<Image>();
            dropdownIndicatorImage.material = UISpriteWithMipMapBiasOverride;
            dropdownIndicatorImage.sprite = DropdownDownIndicator;
            dropdownIndicatorImage.raycastTarget = false;
            HUDDropdownControl hudDropdownControl = Dropdown.AddComponent<HUDDropdownControl>();
            HUDLocalizedText labelHudLocalizedText = AddLocalizedTextSecondary(Dropdown.transform, hudDropdownControl);
            labelHudLocalizedText.name = "Label";
            RectTransform labelRectTransform = labelHudLocalizedText.gameObject.GetComponent<RectTransform>();
            labelRectTransform.anchorMin = Vector2.zero;
            labelRectTransform.anchorMax = Vector2.one;
            labelRectTransform.offsetMin = new Vector2(11.1181f, 6f);
            labelRectTransform.offsetMax = new Vector2(-23.6303f, -7f);
            TMP_Text labelText = labelHudLocalizedText.UIText;
            labelText.alignment = TextAlignmentOptions.Left;
            labelText.color = Color.white;
            labelText.fontSize = 19.85f;
            labelText.fontSizeMax = 20;
            labelText.fontSizeMin = 5;
            labelText.overflowMode = TextOverflowModes.Ellipsis;
            GameObject Template = new GameObject("Template");
            Template.transform.SetParent(Dropdown.transform);
            Template.layer = LayerMask.NameToLayer("UI");
            RectTransform templateRectTransform = Template.AddComponent<RectTransform>();
            templateRectTransform.pivot = new Vector2(0.5f, 1);
            templateRectTransform.anchorMin = Vector2.zero;
            templateRectTransform.anchorMax = Vector2.right;
            templateRectTransform.offsetMin = new Vector2(0f, -232.6337f);
            templateRectTransform.offsetMax = new Vector2(0f, -10.4f);
            GameObject Bg = new GameObject("Bg");
            Bg.transform.SetParent(Template.transform);
            Bg.layer = LayerMask.NameToLayer("UI");
            RectTransform bgRectTransform = Bg.AddComponent<RectTransform>();
            bgRectTransform.anchorMin = Vector2.zero;
            bgRectTransform.anchorMax = Vector2.one;
            bgRectTransform.offsetMin = Vector2.zero;
            bgRectTransform.offsetMax = new Vector2(0, 3.9962f);
            AddSecondaryPanel(Bg.transform);
            GameObject Viewport = new GameObject("Viewport");
            Viewport.transform.SetParent(Template.transform);
            Viewport.layer = LayerMask.NameToLayer("UI");
            RectTransform viewportRectTransform = Viewport.AddComponent<RectTransform>();
            viewportRectTransform.pivot = Vector2.up;
            viewportRectTransform.anchorMin = Vector2.zero;
            viewportRectTransform.anchorMax = Vector2.one;
            viewportRectTransform.offsetMin = Vector2.zero;
            viewportRectTransform.offsetMax = new Vector2(-17, 0);
            Image viewportImage = Viewport.AddComponent<Image>();
            viewportImage.type = Image.Type.Sliced;
            Mask viewportMask = Viewport.AddComponent<Mask>();
            viewportMask.showMaskGraphic = false;
            GameObject Content = new GameObject("Content");
            Content.transform.SetParent(Viewport.transform);
            Content.layer = LayerMask.NameToLayer("UI");
            RectTransform contentRectTransform = Content.AddComponent<RectTransform>();
            contentRectTransform.pivot = new Vector2(0.5f, 1);
            contentRectTransform.anchorMin = Vector2.up;
            contentRectTransform.anchorMax = Vector2.one;
            contentRectTransform.offsetMin = new Vector2(5, -48);
            contentRectTransform.offsetMax = new Vector2(-5, 0);
            GameObject Item = new GameObject("Item");
            Item.transform.SetParent(Content.transform);
            Item.layer = LayerMask.NameToLayer("UI");
            RectTransform itemRectTransform = Item.AddComponent<RectTransform>();
            itemRectTransform.anchorMin = Vector2.up;
            itemRectTransform.anchorMax = Vector2.one;
            itemRectTransform.offsetMin = new Vector2(0, -42.5f);
            itemRectTransform.offsetMax = new Vector2(0, -2.5f);
            GameObject ItemBackground = new GameObject("Item Background");
            ItemBackground.transform.SetParent(Item.transform);
            ItemBackground.layer = LayerMask.NameToLayer("UI");
            RectTransform itemBackgroundRectTransform = ItemBackground.AddComponent<RectTransform>();
            itemBackgroundRectTransform.anchorMin = new Vector2(0, 0.5f);
            itemBackgroundRectTransform.anchorMax = new Vector2(1, 0.5f);
            itemBackgroundRectTransform.offsetMin = new Vector2(3, -19);
            itemBackgroundRectTransform.offsetMax = new Vector2(-3, 19);
            UniformModifier itemBackgroundUniformModifier = ItemBackground.AddComponent<UniformModifier>();
            ProceduralImage itemBackgroundProceduralImage = ItemBackground.AddComponent<ProceduralImage>();
            itemBackgroundProceduralImage.BorderWidth = 0;
            itemBackgroundProceduralImage.color = new Color(1, 1, 1, 1);
            itemBackgroundProceduralImage.raycastPadding = new Vector4(-3, -4, -3, -4);
            itemBackgroundUniformModifier.Radius = 12;
            GameObject ItemCheckmark = new GameObject("Item Checkmark");
            ItemCheckmark.transform.SetParent(Item.transform);
            ItemCheckmark.layer = LayerMask.NameToLayer("UI");
            RectTransform itemCheckmarkRectTransform = ItemCheckmark.AddComponent<RectTransform>();
            itemCheckmarkRectTransform.anchorMin = Vector2.zero;
            itemCheckmarkRectTransform.anchorMax = Vector2.one;
            itemCheckmarkRectTransform.offsetMin = new Vector2(3, 3);
            itemCheckmarkRectTransform.offsetMax = new Vector2(-3, -4);
            UniformModifier itemCheckmarkUniformModifier = ItemCheckmark.AddComponent<UniformModifier>();
            ProceduralImage itemCheckmarkProceduralImage = ItemCheckmark.AddComponent<ProceduralImage>();
            itemCheckmarkProceduralImage.BorderWidth = 1;
            itemCheckmarkProceduralImage.color = new Color(0.1098f, 0.7608f, 1, 0.2f);
            itemCheckmarkProceduralImage.raycastPadding = new Vector4(0, 0, 0, 0);
            itemCheckmarkProceduralImage.type = Image.Type.Filled;
            itemCheckmarkUniformModifier.Radius = 8;
            itemCheckmarkProceduralImage.enabled = false;
            GameObject ItemLabel = new GameObject("Item Label");
            ItemLabel.transform.SetParent(Item.transform);
            ItemLabel.layer = LayerMask.NameToLayer("UI");
            RectTransform itemLabelRectTransform = ItemLabel.AddComponent<RectTransform>();
            itemLabelRectTransform.anchorMin = Vector2.zero;
            itemLabelRectTransform.anchorMax = Vector2.one;
            itemLabelRectTransform.offsetMin = new Vector2(10.1729f, 1);
            itemLabelRectTransform.offsetMax = new Vector2(-6.7594f, -2);
            TextMeshProUGUI itemLabelText = ItemLabel.AddComponent<TextMeshProUGUI>();
            SetupSecondaryText(itemLabelText);
            itemLabelText.color = new Color(1, 1, 1, 0.8431f);
            itemLabelText.fontSize = 10;
            itemLabelText.fontSizeMin = 10;
            itemLabelText.alignment = TextAlignmentOptions.Left;
            Toggle itemToggle = Item.AddComponent<Toggle>();
            itemToggle.colors = new ColorBlock()
            {
                normalColor = new Color(1, 1, 1, 0),
                highlightedColor = new Color(1, 1, 1, 0.0157f),
                pressedColor = new Color(1, 1, 1, 0.102f),
                selectedColor = new Color(1, 1, 1, 0.102f),
                disabledColor = new Color(1, 1, 1, 0),
                colorMultiplier = 1,
                fadeDuration = 0.2f
            };
            itemToggle.isOn = true;
            itemToggle.image = itemBackgroundProceduralImage;
            GameObject Scrollbar = new GameObject("Scrollbar");
            Scrollbar.transform.SetParent(Template.transform);
            Scrollbar.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarRectTransform = Scrollbar.AddComponent<RectTransform>();
            Image scrollbarImage = Scrollbar.AddComponent<Image>();
            scrollbarImage.type = Image.Type.Sliced;
            scrollbarImage.color = Color.clear;
            scrollbarImage.enabled = false;
            GameObject ScrollbarSlidingArea = new GameObject("Sliding Area");
            ScrollbarSlidingArea.transform.SetParent(Scrollbar.transform);
            ScrollbarSlidingArea.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarSlidingAreaRectTransform = ScrollbarSlidingArea.AddComponent<RectTransform>();
            GameObject ScrollbarHandle = new GameObject("Handle");
            ScrollbarHandle.transform.SetParent(ScrollbarSlidingArea.transform);
            ScrollbarHandle.layer = LayerMask.NameToLayer("UI");
            RectTransform scrollbarHandleRectTransform = ScrollbarHandle.AddComponent<RectTransform>();
            scrollbarHandleRectTransform.anchorMin = Vector2.zero;
            scrollbarHandleRectTransform.anchorMax = Vector2.one;
            scrollbarHandleRectTransform.offsetMin = new Vector2(-3, -3);
            scrollbarHandleRectTransform.offsetMax = new Vector2(3, 3);
            Image scrollbarHandleImage = ScrollbarHandle.AddComponent<Image>();
            scrollbarHandleImage.sprite = HUDScrollbarPanelBg;
            scrollbarHandleImage.type = Image.Type.Sliced;
            scrollbarHandleImage.pixelsPerUnitMultiplier = 7;
            scrollbarHandleImage.raycastPadding = new Vector4(0, 0, 0, 0);
            Scrollbar scrollbarScrollbar = Scrollbar.AddComponent<Scrollbar>();
            scrollbarScrollbar.handleRect = scrollbarHandleRectTransform;
            scrollbarScrollbar.targetGraphic = scrollbarHandleImage;
            scrollbarScrollbar.SetDirection(UnityEngine.UI.Scrollbar.Direction.BottomToTop, true);
            scrollbarScrollbar.colors = new ColorBlock()
            {
                normalColor = new Color(0.9198f, 0.9236f, 1, 0.0353f),
                highlightedColor = new Color(0.9216f, 0.9255f, 1, 0.1059f),
                pressedColor = new Color(0.9216f, 0.9255f, 1, 0.1647f),
                selectedColor = new Color(0.9216f, 0.9255f, 1, 0.149f),
                disabledColor = new Color(0.9216f, 0.9255f, 1, 0.0078f),
                colorMultiplier = 1,
                fadeDuration = 0.2f
            };
            ScrollRect templateScrollRect = Template.AddComponent<ScrollRect>();
            templateScrollRect.content = contentRectTransform;
            templateScrollRect.viewport = viewportRectTransform;
            templateScrollRect.verticalScrollbar = scrollbarScrollbar;
            templateScrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            templateScrollRect.verticalScrollbarSpacing = -3f;
            templateScrollRect.decelerationRate = 0.135f;
            templateScrollRect.movementType = ScrollRect.MovementType.Clamped;
            templateScrollRect.normalizedPosition = Vector2.zero;
            scrollbarRectTransform.pivot = Vector2.one;
            scrollbarRectTransform.anchorMin = Vector2.right;
            scrollbarRectTransform.anchorMax = Vector2.one;
            scrollbarRectTransform.offsetMin = new Vector2(-20, 0);
            scrollbarRectTransform.offsetMax = Vector2.zero;
            scrollbarSlidingAreaRectTransform.anchorMin = Vector2.zero;
            scrollbarSlidingAreaRectTransform.anchorMax = Vector2.one;
            scrollbarSlidingAreaRectTransform.anchoredPosition = new Vector2(0, 0);
            scrollbarSlidingAreaRectTransform.sizeDelta = new Vector2(-20, -20);
            GameObject Arrow = new GameObject("Arrow");
            Arrow.transform.SetParent(Template.transform);
            Arrow.layer = LayerMask.NameToLayer("UI");
            RectTransform arrowRectTransform = Arrow.AddComponent<RectTransform>();
            arrowRectTransform.anchorMin = new Vector2(0.5f, 1);
            arrowRectTransform.anchorMax = new Vector2(0.5f, 1);
            arrowRectTransform.offsetMin = new Vector2(-12.4797f, -3.8797f);
            arrowRectTransform.offsetMax = new Vector2(12.4797f, 21.0797f);
            arrowRectTransform.rotation = Quaternion.Euler(0, 0, 180);
            Image arrowImage = Arrow.AddComponent<Image>();
            arrowImage.material = UISpriteWithMipMapBiasOverride;
            arrowImage.sprite = HUDTooltipArrowClean;
            arrowImage.raycastTarget = false;
            HUDCustomTMPDropdown hudCustomTMPDropdown = Dropdown.AddComponent<HUDCustomTMPDropdown>();
            hudCustomTMPDropdown.template = templateRectTransform;
            hudCustomTMPDropdown.itemText = itemLabelText;
            hudDropdownControl.UIDropdown = hudCustomTMPDropdown;
            hudDropdownControl.UIMainGroup = canvasGroup;
            hudDropdownControl.UIValueText = labelHudLocalizedText;
            hudCustomTMPDropdown.colors = new ColorBlock()
            {
                normalColor = new Color(1, 1, 1, 0),
                highlightedColor = new Color(1, 1, 1, 1),
                pressedColor = new Color(1, 1, 1, 1),
                selectedColor = new Color(1, 1, 1, 0.4902f),
                disabledColor = new Color(1, 1, 1, 0),
                colorMultiplier = 1,
                fadeDuration = 0.1f
            };
            hudCustomTMPDropdown.image = hoverImageImage;
            return hudDropdownControl;
        }
        private static HUDSliderControl CreateSlider()
        {
            GameObject Slider = new GameObject("Slider");
            GameObject.DontDestroyOnLoad(Slider);
            Slider.SetActiveSelfExt(false);
            Slider.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = Slider.AddComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0, 0.5f);
            rectTransform.anchorMax = new Vector2(1, 0.5f);
            rectTransform.offsetMin = new Vector2(0, -25);
            rectTransform.offsetMax = new Vector2(0, 25);
            HUDSliderControl hudSliderControl = Slider.AddComponent<HUDSliderControl>();
            HUDLocalizedText hudLocalizedText = AddLocalizedTextSecondary(Slider.transform, hudSliderControl);
            hudLocalizedText.gameObject.name = "Text";
            RectTransform textRectTransform = hudLocalizedText.gameObject.GetComponent<RectTransform>();
            textRectTransform.anchorMin = new Vector2(1, 0.5f);
            textRectTransform.anchorMax = new Vector2(1, 0.5f);
            textRectTransform.offsetMin = new Vector2(-57.8628f, -15.8583f);
            textRectTransform.offsetMax = new Vector2(0, 15.8583f);
            TMP_Text text = hudLocalizedText.UIText;
            text.enableAutoSizing = false;
            GameObject SliderSlider = new GameObject("Slider");
            SliderSlider.transform.SetParent(Slider.transform);
            SliderSlider.layer = LayerMask.NameToLayer("UI");
            RectTransform sliderSliderRectTransform = SliderSlider.AddComponent<RectTransform>();
            sliderSliderRectTransform.anchorMin = new Vector2(0, 0.5f);
            sliderSliderRectTransform.anchorMax = new Vector2(1, 0.5f);
            sliderSliderRectTransform.offsetMin = new Vector2(0, -10);
            sliderSliderRectTransform.offsetMax = new Vector2(-63.4414f, 10);
            GameObject Background = new GameObject("Background");
            Background.transform.SetParent(SliderSlider.transform);
            Background.layer = LayerMask.NameToLayer("UI");
            RectTransform backgroundRectTransform = Background.AddComponent<RectTransform>();
            backgroundRectTransform.anchorMin = new Vector2(0, 0.25f);
            backgroundRectTransform.anchorMax = new Vector2(1, 0.75f);
            backgroundRectTransform.offsetMin = new Vector2(8.2233f, 3.7035f);
            backgroundRectTransform.offsetMax = new Vector2(-9.3393f, -3.7035f);
            Image backgroundImage = Background.AddComponent<Image>();
            backgroundImage.sprite = HUDSliderTrackPattern;
            backgroundImage.pixelsPerUnitMultiplier = 6.81f;
            backgroundImage.type = Image.Type.Tiled;
            backgroundImage.color = new Color(1, 1, 1, 0.051f);
            backgroundImage.raycastPadding = new Vector4(0, -7, 0, -7);
            GameObject FillArea = new GameObject("Fill Area");
            FillArea.transform.SetParent(SliderSlider.transform);
            FillArea.layer = LayerMask.NameToLayer("UI");
            RectTransform fillAreaRectTransform = FillArea.AddComponent<RectTransform>();
            fillAreaRectTransform.anchorMin = new Vector2(0, 0.25f);
            fillAreaRectTransform.anchorMax = new Vector2(1, 0.75f);
            fillAreaRectTransform.offsetMin = new Vector2(11.806f, 0);
            fillAreaRectTransform.offsetMax = new Vector2(-15, 0);
            GameObject Fill = new GameObject("Fill");
            Fill.transform.SetParent(FillArea.transform);
            Fill.layer = LayerMask.NameToLayer("UI");
            RectTransform fillRectTransform = Fill.AddComponent<RectTransform>();
            fillRectTransform.anchorMin = Vector2.zero;
            fillRectTransform.anchorMax = Vector2.zero;
            fillRectTransform.offsetMin = new Vector2(-5, 3.51f);
            fillRectTransform.offsetMax = new Vector2(5, -3.51f);
            UniformModifier fillUniformModifier = Fill.AddComponent<UniformModifier>();
            ProceduralImage fillProceduralImage = Fill.AddComponent<ProceduralImage>();
            fillProceduralImage.BorderWidth = 0;
            fillProceduralImage.raycastPadding = new Vector4(0, -5, 0, -5);
            fillUniformModifier.Radius = 20;
            GameObject HandleSlideArea = new GameObject("Handle Slide Area");
            HandleSlideArea.transform.SetParent(SliderSlider.transform);
            HandleSlideArea.layer = LayerMask.NameToLayer("UI");
            RectTransform handleSlideAreaRectTransform = HandleSlideArea.AddComponent<RectTransform>();
            handleSlideAreaRectTransform.anchorMin = Vector2.zero;
            handleSlideAreaRectTransform.anchorMax = Vector2.one;
            handleSlideAreaRectTransform.offsetMin = new Vector2(10, 0);
            handleSlideAreaRectTransform.offsetMax = new Vector2(-10, 0);
            GameObject Handle = new GameObject("Handle");
            Handle.transform.SetParent(HandleSlideArea.transform);
            Handle.layer = LayerMask.NameToLayer("UI");
            RectTransform handleRectTransform = Handle.AddComponent<RectTransform>();
            handleRectTransform.anchorMin = Vector2.zero;
            handleRectTransform.anchorMax = Vector2.zero;
            handleRectTransform.offsetMin = new Vector2(-6, 4);
            handleRectTransform.offsetMax = new Vector2(6, -4);
            Handle.AddComponent<RoundModifier>();
            ProceduralImage handleProceduralImage = Handle.AddComponent<ProceduralImage>();
            handleProceduralImage.BorderWidth = 0;
            handleProceduralImage.raycastPadding = new Vector4(-7, -5, -7, -5);
            Slider sliderSliderSlider = SliderSlider.AddComponent<Slider>();
            sliderSliderSlider.fillRect = fillRectTransform;
            sliderSliderSlider.handleRect = handleRectTransform;
            sliderSliderSlider.colors = new ColorBlock()
            {
                normalColor = Color.white,
                highlightedColor = new Color(1, 0.6167f, 0, 0.9686f),
                pressedColor = new Color(0.8019f, 0.4937f, 0, 0.9686f),
                selectedColor = Color.white,
                disabledColor = new Color(1, 1, 1, 0.6392f),
                colorMultiplier = 1,
                fadeDuration = 0.2f
            };
            sliderSliderSlider.image = handleProceduralImage;
            sliderSliderSlider.wholeNumbers = true;
            hudSliderControl.UISlider = sliderSliderSlider;
            hudSliderControl.UIValueText = hudLocalizedText;
            return hudSliderControl;
        }
        public static void SetupPrimaryText(TextMeshProUGUI text)
        {
            text.color = new Color(1, 1, 1, 0.749f);
            text.enableAutoSizing = true;
            text.fontFeatures = new List<UnityEngine.TextCore.OTL_FeatureTag> { UnityEngine.TextCore.OTL_FeatureTag.kern };
            text.font = FontMediumSDF;
            text.fontSize = 20;
            text.fontSizeMax = 20;
            text.fontSizeMin = 12;
            text.fontStyle = FontStyles.UpperCase;
            text.horizontalAlignment = HorizontalAlignmentOptions.Center;
            text.isOrthographic = true;
            text.margin = new Vector4(0, 0, -0.0001f, 0);
            text.overflowMode = TextOverflowModes.Ellipsis;
            text.verticalAlignment = VerticalAlignmentOptions.Middle;
            text.raycastTarget = false;
        }
        public static void SetupSecondaryText(TextMeshProUGUI text)
        {
            text.color = new Color(1, 1, 1, 0.502f);
            text.enableAutoSizing = true;
            text.font = FontLightSDF;
            text.fontSize = 20;
            text.fontSizeMax = 20;
            text.fontSizeMin = 12;
            text.fontStyle = FontStyles.Normal;
            text.horizontalAlignment = HorizontalAlignmentOptions.Center;
            text.isOrthographic = true;
            text.verticalAlignment = VerticalAlignmentOptions.Middle;
            text.raycastTarget = false;
        }
        public static GameObject AddPanel(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject panel = GameObject.Instantiate(Panel, target, false);
            panel.transform.localScale = Vector3.one;
            panel.SetActiveSelfExt(true);
            var component = panel.transform.GetChild(0).GetComponent<HUDTranslucentImageWithCameraResultAsImageSource>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDTranslucentImageWithCameraResultAsImageSource>(component);
            return panel;
        }
        public static GameObject AddSecondaryPanel(Transform target)
        {
            GameObject secondaryPanel = GameObject.Instantiate(SecondaryPanel, target, false);
            secondaryPanel.transform.localScale = Vector3.one;
            secondaryPanel.SetActiveSelfExt(true);
            return secondaryPanel;
        }
        public static HUDButton AddButton(Transform target, HUDComponent targetComponent, bool ConstructNow = false, bool secondary = false)
        {
            GameObject button = GameObject.Instantiate(Button.gameObject, target, false);
            button.transform.localScale = Vector3.one;
            button.SetActiveSelfExt(true);
            var component = button.GetComponent<HUDButton>();
            if (secondary) button.transform.GetChild(0).GetComponent<Image>().sprite = HUDSecondaryButtonBase;
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDButton>(component);
            return component;
        }
        public static HUDAnimatedRoundButton AddAnimatedRoundButton(Transform target, HUDComponent targetComponent, bool ConstructNow = false, Sprite? icon = null)
        {
            GameObject button = GameObject.Instantiate(AnimatedRoundButton.gameObject, target, false);
            button.transform.localScale = Vector3.one;
            button.SetActiveSelfExt(true);
            var component = button.GetComponent<HUDAnimatedRoundButton>();
            if (icon != null) component.UIIconSprite = icon;
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDAnimatedRoundButton>(component);
            return component;
        }
        public static HUDIconButton AddIconButton(Transform target, HUDComponent targetComponent, bool ConstructNow = false, Sprite? icon = null)
        {
            GameObject button = GameObject.Instantiate(IconButton.gameObject, target, false);
            button.transform.localScale = Vector3.one;
            button.SetActiveSelfExt(true);
            var component = button.GetComponent<HUDIconButton>();
            if (icon != null) component._Icon = icon;
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDIconButton>(component);
            return component;
        }
        public static TextMeshProUGUI AddTextPrimary(Transform target)
        {
            GameObject text = GameObject.Instantiate(TextPrimary.gameObject, target, false);
            text.transform.localScale = Vector3.one;
            text.SetActiveSelfExt(true);
            return text.GetComponent<TextMeshProUGUI>();
        }
        public static TextMeshProUGUI AddTextSecondary(Transform target)
        {
            GameObject text = GameObject.Instantiate(TextSecondary.gameObject, target, false);
            text.transform.localScale = Vector3.one;
            text.SetActiveSelfExt(true);
            return text.GetComponent<TextMeshProUGUI>();
        }
        public static HUDLocalizedText AddLocalizedTextPrimary(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject localizedText = GameObject.Instantiate(LocalizedTextPrimary.gameObject, target, false);
            localizedText.transform.localScale = Vector3.one;
            localizedText.SetActiveSelfExt(true);
            var component = localizedText.GetComponent<HUDLocalizedText>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDLocalizedText>(component);
            return component;
        }
        public static HUDLocalizedText AddLocalizedTextSecondary(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject localizedText = GameObject.Instantiate(LocalizedTextSecondary.gameObject, target, false);
            localizedText.transform.localScale = Vector3.one;
            localizedText.SetActiveSelfExt(true);
            var component = localizedText.GetComponent<HUDLocalizedText>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDLocalizedText>(component);
            return component;
        }
        public static HUDInputField AddInputField(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject inputField = GameObject.Instantiate(InputField.gameObject, target, false);
            inputField.transform.localScale = Vector3.one;
            inputField.SetActiveSelfExt(true);
            var component = inputField.GetComponent<HUDInputField>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDInputField>(component);
            return component;
        }
        public static HUDScrollContainer AddScrollContainer(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject scrollContainer = GameObject.Instantiate(ScrollContainer.gameObject, target, false);
            scrollContainer.transform.localScale = Vector3.one;
            scrollContainer.SetActiveSelfExt(true);
            scrollContainer.GetComponent<ScrollRect>().content.gameObject.AddComponent<GraphicRaycaster>().blockingMask = 55;
            var component = scrollContainer.GetComponent<HUDScrollContainer>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDScrollContainer>(component);
            return component;
        }
        public static GameObject AddDivider(Transform target, bool bottom = false, bool scroll = true)
        {
            GameObject divider = GameObject.Instantiate(Divider, target, false);
            divider.transform.localScale = Vector3.one;
            if (bottom)
            {
                RectTransform rectTransform = divider.GetComponent<RectTransform>();
                rectTransform.anchorMin = Vector2.zero;
                rectTransform.anchorMax = Vector2.right;
            }
            if (!scroll)
            {
                divider.GetComponentInChildren<Image>().sprite = HUDAntiAliasedHorizontalDivider;
            }
            divider.SetActiveSelfExt(true);
            return divider;
        }
        public static HUDToggleControl AddToggle(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject toggle = GameObject.Instantiate(Toggle.gameObject, target, false);
            toggle.transform.localScale = Vector3.one;
            toggle.SetActiveSelfExt(true);
            var component = toggle.GetComponent<HUDToggleControl>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDToggleControl>(component);
            return component;
        }
        public static HUDDropdownControl AddDropdown(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject dropdown = GameObject.Instantiate(Dropdown.gameObject, target, false);
            dropdown.transform.localScale = Vector3.one;
            dropdown.SetActiveSelfExt(true);
            var component = dropdown.GetComponent<HUDDropdownControl>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDDropdownControl>(component);
            return component;
        }
        public static HUDEnumSelectorControl AddEnumSelector(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject enumSelector = GameObject.Instantiate(EnumSelector.gameObject, target, false);
            enumSelector.transform.localScale = Vector3.one;
            enumSelector.SetActiveSelfExt(true);
            var component = enumSelector.GetComponent<HUDEnumSelectorControl>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDEnumSelectorControl>(component);
            return component;
        }
        public static HUDSliderControl AddSlider(Transform target, HUDComponent targetComponent, bool ConstructNow = false)
        {
            GameObject slider = GameObject.Instantiate(Slider.gameObject, target, false);
            slider.transform.localScale = Vector3.one;
            slider.SetActiveSelfExt(true);
            var component = slider.GetComponent<HUDSliderControl>();
            targetComponent.AddChildComponentReference(component);
            if (ConstructNow) targetComponent.AddChildViewInternal<HUDSliderControl>(component);
            return component;
        }
        /// <summary>
        /// helper to add a HUDComponent to a HUDComponent
        /// the ui will be created at the full size of the parent by default
        /// modify the RectTransform yourself to change the size/position
        /// </summary>
        /// <typeparam name="T">the HUDComponent type to add</typeparam>
        /// <param name="uiConstructor">add ui elements in here</param>
        /// <param name="parent">the parent to add the HUDComponent to</param>
        /// <param name="name">the name of the new ui gameobject</param>
        /// <param name="ConstructNow">if it should be constructed now, set this to true if doing this in the construct function or if the ui has already been constructed</param>
        /// <returns>the added HUDComponent to then add elements to</returns>
        public static T AddHUDComponentToHUDComponent<T>(Action<T> uiConstructor, HUDComponent parent, string name, bool ConstructNow = false) where T : HUDComponent
        {
            GameObject gameObject = new GameObject(name);
            gameObject.transform.SetParent(parent.transform);
            gameObject.transform.localScale = Vector3.one;
            gameObject.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            T ui = gameObject.AddComponent<T>();
            uiConstructor.Invoke(ui);
            parent.AddChildComponentReference(ui);
            if (ConstructNow) parent.AddChildViewInternal<T>(ui);
            return ui;
        }
        /// <summary>
        /// helper to add a HUDComponent to a HUDComponent
        /// the ui will be created at the full size of the parent by default
        /// modify the RectTransform yourself to change the size/position
        /// </summary>
        /// <param name="Type">the HUDComponent type to add</typeparam>
        /// <param name="uiConstructor">add ui elements in here</param>
        /// <param name="parent">the parent to add the HUDComponent to</param>
        /// <param name="name">the name of the new ui gameobject</param>
        /// <param name="ConstructNow">if it should be constructed now, set this to true if doing this in the construct function or if the ui has already been constructed</param>
        /// <returns>the added HUDComponent to then add elements to</returns>
        public static HUDComponent AddHUDComponentToHUDComponent(Type type, Action<HUDComponent> uiConstructor, HUDComponent parent, string name, bool ConstructNow = false)
        {
            GameObject gameObject = new GameObject(name);
            gameObject.transform.SetParent(parent.transform);
            gameObject.transform.localScale = Vector3.one;
            gameObject.layer = LayerMask.NameToLayer("UI");
            RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.one;
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
            HUDComponent ui = (HUDComponent)gameObject.AddComponent(type);
            uiConstructor.Invoke(ui);
            parent.AddChildComponentReference(ui);
            if (ConstructNow) parent.AddChildViewInternal(type, ui);
            return ui;
        }
    }
}
