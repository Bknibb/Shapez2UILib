using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TMPro;
using System.Linq;
using UnityEngine;

namespace Shapez2UILib
{
    public static class StaticResources
    {
        public static readonly FieldInfo componentChildComponentReferences = AccessTools.Field(typeof(HUDComponent), "ChildComponentReferences");
        public static readonly MethodInfo componentAddChildViewInternal = AccessTools.Method(typeof(HUDComponent), "AddChildViewInternal");
        public static readonly FieldInfo componentDependencyResolver = AccessTools.Field(typeof(HUDComponent), "DependencyResolver");
        public static readonly Sprite HUDButtonBase = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDButtonBase");
        public static readonly Sprite HUDSecondaryButtonBase = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDSecondaryButtonBase");
        public static readonly Sprite HUDButtonHover = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDButtonHover");
        public static readonly Sprite HUDPrimaryLightPanelMask = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDPrimaryLightPanelMask");
        public static readonly Sprite HUDPrimaryLightPanel = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDPrimaryLightPanel");
        public static readonly Sprite HUDScrollbarPanelBg = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDScrollbarPanelBg");
        public static readonly Sprite HUDAntiAliasedHorizontalScrollDivider = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDAntiAliasedHorizontalScrollDivider");
        public static readonly Sprite HUDAntiAliasedHorizontalDivider = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDAntiAliasedHorizontalDivider");
        public static readonly Material DefaultTranslucent = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "Default-Translucent");
        public static readonly Material UIAnimatedPanelMenuMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedPanelMenuMaterial");
        public static readonly Material UISpriteWithMipMapBiasOverride = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-SpriteWithMipMapBiasOverride");
        public static readonly Material UIAnimatedButtonMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedButtonMaterial");
        public static readonly TMP_FontAsset FontMediumSDF = Resources.FindObjectsOfTypeAll<TMP_FontAsset>().First(m => m.name == "Font-Medium SDF");
        public static readonly TMP_FontAsset FontLightSDF = Resources.FindObjectsOfTypeAll<TMP_FontAsset>().First(m => m.name == "Font-Light SDF");
        public static readonly FieldInfo HUDInputFieldUIInputFieldInfo = AccessTools.Field(typeof(HUDInputField), "UIInputField");
        public static readonly FieldInfo HUDInputFieldUIPlaceholderTextInfo = AccessTools.Field(typeof(HUDInputField), "UIPlaceholderText");
        public static readonly FieldInfo HUDScrollContainerUIScrollRectInfo = AccessTools.Field(typeof(HUDScrollContainer), "UIScrollRect");
        public static readonly FieldInfo HUDLocalizedTextUITextInfo = AccessTools.Field(typeof(HUDLocalizedText), "UIText");
        public static readonly FieldInfo HUDButtonUITextInfo = AccessTools.Field(typeof(HUDButton), "UIText");
        public static readonly FieldInfo HUDButtonUIButtonInfo = AccessTools.Field(typeof(HUDButton), "UIButton");
        public static readonly FieldInfo HUDButtonUIMainGroupInfo = AccessTools.Field(typeof(HUDButton), "UIMainGroup");
        public static readonly FieldInfo HUDButtonUIHoverIndicatorGroupInfo = AccessTools.Field(typeof(HUDButton), "UIHoverIndicatorGroup");
        public static readonly FieldInfo HUDButtonUIMainTransformInfo = AccessTools.Field(typeof(HUDButton), "UIMainTransform");
        public static readonly FieldInfo HUDAnimatedRoundButtonUIButtonInfo = AccessTools.Field(typeof(HUDAnimatedRoundButton), "UIButton");
        public static readonly FieldInfo HUDAnimatedRoundButtonUIIconSpriteInfo = AccessTools.Field(typeof(HUDAnimatedRoundButton), "UIIconSprite");
        public static readonly FieldInfo HUDAnimatedRoundButtonUIIconTransformInfo = AccessTools.Field(typeof(HUDAnimatedRoundButton), "UIIconTransform");
        public static readonly FieldInfo HUDAnimatedRoundButtonUIMainIconInfo = AccessTools.Field(typeof(HUDAnimatedRoundButton), "UIMainIcon");
        public static readonly FieldInfo tmpInputFieldRegexValue = AccessTools.Field(typeof(TMP_InputField), "m_RegexValue");
        public static readonly MethodInfo addMenuButtonMethod = AccessTools.Method(typeof(HUDMenuMainState), "AddMenuButton");
        public static readonly MethodInfo IMainMenuStateControlSwitchToStateInfo = AccessTools.Method(typeof(IMainMenuStateControl), nameof(IMainMenuStateControl.SwitchToState));
        public static readonly FieldInfo HUDMenuBackButton_TextIdInfo = AccessTools.Field(typeof(HUDMenuBackButton), "_TextId");
        public static readonly FieldInfo HUDComponentChildren = AccessTools.Field(typeof(HUDComponent), "Children");
        public static readonly FieldInfo HUDComponentLoadedChildren = AccessTools.Field(typeof(HUDComponent), "LoadedChildren");
    }
}
