using Core.Dependency;
using Core.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMPro;
using Unity.Core.View;
using UnityEngine;
using UnityEngine.UI;

namespace Shapez2UILib
{
    public static class UIExtensions
    {
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static TMP_Text GetText(this HUDLocalizedText hudLocalizedText)
        {
            //return (TMP_Text)StaticResources.HUDLocalizedTextUITextInfo.GetValue(hudLocalizedText);
            return hudLocalizedText.UIText;
        }
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static List<IView> GetChildren(this HUDComponent hudComponent)
        {
            //return (List<IView>)StaticResources.HUDComponentChildren.GetValue(hudComponent);
            return hudComponent.Children;
        }
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static HashSet<IView> GetLoadedChildren(this HUDComponent hudComponent)
        {
            //return (HashSet<IView>)StaticResources.HUDComponentLoadedChildren.GetValue(hudComponent);
            return hudComponent.LoadedChildren;
        }
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static void AddChildViewInternal<TViewInterface>(this HUDComponent hudComponent, TViewInterface childView) where TViewInterface : UnityEngine.Object, IView
        {
            //StaticResources.componentAddChildViewInternal.MakeGenericMethod(typeof(TViewInterface)).Invoke(hudComponent, new object[] { childView });
            hudComponent.AddChildViewInternal<TViewInterface>(childView);
        }
        public static void AddChildViewInternal(this HUDComponent hudComponent, Type type, IView childView)
        {
            StaticResources.componentAddChildViewInternal.MakeGenericMethod(type).Invoke(hudComponent, new object[] { childView });
        }
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static IDependencyResolver GetDependencyResolver(this HUDComponent hudComponent)
        {
            //return (IDependencyResolver)StaticResources.componentDependencyResolver.GetValue(hudComponent);
            return hudComponent.DependencyResolver;
        }
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static HUDComponent[] GetChildComponentReferences(this HUDComponent hudComponent)
        {
            //return (HUDComponent[])StaticResources.componentChildComponentReferences.GetValue(hudComponent);
            return hudComponent.ChildComponentReferences;
        }
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static void SetChildComponentReferences(this HUDComponent hudComponent, HUDComponent[] newValue)
        {
            //StaticResources.componentChildComponentReferences.SetValue(hudComponent, newValue);
            hudComponent.ChildComponentReferences = newValue;
        }
        public static void AddChildComponentReference(this HUDComponent hudComponent, HUDComponent toAdd)
        {
            hudComponent.ChildComponentReferences = hudComponent.ChildComponentReferences.Append(toAdd).ToArray();
        }
        [Obsolete("It is recommended to use a Publicizer instead")]
        public static Slider GetSlider(this HUDSliderControl hudSliderControl)
        {
            //return (Slider)StaticResources.HUDSliderControlUISlider.GetValue(hudSliderControl);
            return hudSliderControl.UISlider;
        }
        public static void SetSerializedText(this HUDLocalizedText hudLocalizedText, TranslationId translationId)
        {
            //StaticResources.HUDLocalizedText_TranslationInfo.SetValue(hudLocalizedText, new SerializedTranslationId() { Id = translationId });
            hudLocalizedText._Translation = new SerializedTranslationId() { Id = translationId };
        }
    }
}
