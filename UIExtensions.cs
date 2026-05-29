using Core.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMPro;
using Unity.Core.View;
using UnityEngine;

namespace Shapez2UILib
{
    public static class UIExtensions
    {
        public static TMP_Text GetText(this HUDLocalizedText hudLocalizedText)
        {
            return (TMP_Text)StaticResources.HUDLocalizedTextUITextInfo.GetValue(hudLocalizedText);
        }
        public static List<IView> GetChildren(this HUDComponent hudComponent)
        {
            return (List<IView>)StaticResources.HUDComponentChildren.GetValue(hudComponent);
        }
        public static HashSet<IView> GetLoadedChildren(this HUDComponent hudComponent)
        {
            return (HashSet<IView>)StaticResources.HUDComponentLoadedChildren.GetValue(hudComponent);
        }
        public static void AddChildViewInternal<TViewInterface>(this HUDComponent hudComponent, TViewInterface childView) where TViewInterface : UnityEngine.Object, IView
        {
            StaticResources.componentAddChildViewInternal.MakeGenericMethod(typeof(TViewInterface)).Invoke(hudComponent, new object[] { childView });
        }
        public static void AddChildViewInternal(this HUDComponent hudComponent, Type type, IView childView)
        {
            StaticResources.componentAddChildViewInternal.MakeGenericMethod(type).Invoke(hudComponent, new object[] { childView });
        }
        public static IDependencyResolver GetDependencyResolver(this HUDComponent hudComponent)
        {
            return (IDependencyResolver)StaticResources.componentDependencyResolver.GetValue(hudComponent);
        }
        public static HUDComponent[] GetChildComponentReferences(this HUDComponent hudComponent)
        {
            return (HUDComponent[])StaticResources.componentChildComponentReferences.GetValue(hudComponent);
        }
        public static void SetChildComponentReferences(this HUDComponent hudComponent, HUDComponent[] newValue)
        {
            StaticResources.componentChildComponentReferences.SetValue(hudComponent, newValue);
        }
        public static void AddChildComponentReference(this HUDComponent hudComponent, HUDComponent toAdd)
        {
            hudComponent.SetChildComponentReferences(hudComponent.GetChildComponentReferences().Append(toAdd).ToArray());
        }
    }
}
