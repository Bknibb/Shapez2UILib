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
        public static readonly MethodInfo componentAddChildViewInternal = AccessTools.Method(typeof(HUDComponent), "AddChildViewInternal");
        public static readonly Sprite HUDButtonBase = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDButtonBase");
        public static readonly Sprite HUDSecondaryButtonBase = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDSecondaryButtonBase");
        public static readonly Sprite HUDButtonHover = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDButtonHover");
        public static readonly Sprite HUDPrimaryLightPanelMask = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDPrimaryLightPanelMask");
        public static readonly Sprite HUDPrimaryLightPanel = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDPrimaryLightPanel");
        public static readonly Sprite HUDSecondaryPanel = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDSecondaryPanel");
        public static readonly Sprite HUDScrollbarPanelBg = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDScrollbarPanelBg");
        public static readonly Sprite HUDAntiAliasedHorizontalScrollDivider = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDAntiAliasedHorizontalScrollDivider");
        public static readonly Sprite HUDAntiAliasedHorizontalDivider = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDAntiAliasedHorizontalDivider");
        public static readonly Sprite HUDIconButtonBase = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDIconButtonBase");
        public static readonly Sprite HUDIconButtonHover = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDIconButtonHover");
        public static readonly Sprite HUDIconButtonActive = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDIconButtonActive");
        public static readonly Sprite HUDPanelHighlightFG = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDPanelHighlightFG");
        public static readonly Sprite HUDIconButtonHighlight = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDIconButtonHighlight");
        public static readonly Sprite HUDSoloBadge = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDSoloBadge");
        public static readonly Sprite HUDPanelButtonBase = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDPanelButtonBase");
        public static readonly Sprite HUDTooltipArrowClean = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDTooltipArrowClean");
        public static readonly Sprite DropdownDownIndicator = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "DropdownDownIndicator");
        public static readonly Sprite HUDSliderTrackPattern = Resources.FindObjectsOfTypeAll<Sprite>().First(t => t.name == "HUDSliderTrackPattern");
        public static readonly Material DefaultTranslucent = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "Default-Translucent");
        public static readonly Material UIAnimatedPanelMenuMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedPanelMenuMaterial");
        public static readonly Material UISpriteWithMipMapBiasOverride = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-SpriteWithMipMapBiasOverride");
        public static readonly Material UIAnimatedButtonMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedButtonMaterial");
        public static readonly Material UIAnimatedButtonBaseMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedButtonBaseMaterial");
        public static readonly Material UIAnimatedIconMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedIconMaterial");
        public static readonly Material UIAnimatedIconButtonMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedIconButtonMaterial");
        public static readonly Material UIAnimatedHighlightMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedHighlightMaterial");
        public static readonly Material UIAnimatedSecondaryPanelMaterial = Resources.FindObjectsOfTypeAll<Material>().First(m => m.name == "UI-AnimatedSecondaryPanelMaterial");
        public static readonly TMP_FontAsset FontMediumSDF = Resources.FindObjectsOfTypeAll<TMP_FontAsset>().First(m => m.name == "Font-Medium SDF");
        public static readonly TMP_FontAsset FontLightSDF = Resources.FindObjectsOfTypeAll<TMP_FontAsset>().First(m => m.name == "Font-Light SDF");
        public static readonly MethodInfo IMainMenuStateControlSwitchToStateInfo = AccessTools.Method(typeof(IMainMenuStateControl), nameof(IMainMenuStateControl.SwitchToState));
    }
}
