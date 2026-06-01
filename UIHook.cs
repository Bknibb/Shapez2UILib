using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using static UnityEngine.GraphicsBuffer;

namespace Shapez2UILib
{
    public static class UIHook
    {
        private static readonly List<ElementHook> elementHooks = new List<ElementHook>();
        private static readonly List<ConstructorHooks> constructorHooks = new List<ConstructorHooks>();
        private static readonly List<Action> lateStartHooks = new List<Action>();
        [HarmonyPatch(typeof(HUDComponent), "Construct")]
        [HarmonyPostfix]
        private static void HUDComponentConstructorPostfix(HUDComponent __instance)
        {
            foreach (var hook in elementHooks)
            {
                if (hook.target == __instance.GetType())
                {
                    UIFactory.AddHUDComponentToHUDComponent(hook.uiType, hook.uiConstructor, __instance, hook.name, true);
                }
            }
            foreach (var hook in constructorHooks)
            {
                if (hook.target == __instance.GetType())
                {
                    hook.constructor.Invoke(__instance);
                }
            }
        }
        public static bool RanLateStarts { get; private set; } = false;
        [HarmonyPatch(typeof(MainMenuOrchestrator), "Step_0_2_InitStates")]
        [HarmonyPrefix]
        private static void MainMenuOrchestratorStep_0_2_InitStatesPrefix()
        {
            if (RanLateStarts) return;
            RanLateStarts = true;
            foreach (var hook in lateStartHooks) hook.Invoke();
        }
        /// <summary>
        /// adds a custom ui element to the target
        /// this is mainly designed to add a panel, to add standard ui elements use HookUIConstructor instead
        /// </summary>
        /// <typeparam name="T">the type to add</typeparam>
        /// <param name="target">the target type</param>
        /// <param name="uiConstructor">use this to add elements to the custom ui</param>
        /// <param name="name">the name of the custom ui</param>
        public static void ElementHookUI<T>(Type target, Action<T> uiConstructor, string name) where T : HUDComponent
        {
            elementHooks.Add(new ElementHook() { target = target, uiType = typeof(T), uiConstructor = component => uiConstructor.Invoke((T)component), name = name });
        }
        /// <summary>
        /// adds a custom ui element to the target
        /// this is mainly designed to add a panel, to add standard ui elements use HookUIConstructor instead
        /// </summary>
        /// <typeparam name="T">the type to add</typeparam>
        /// <typeparam name="Target">the target type</typeparam>
        /// <param name="uiConstructor">use this to add elements to the custom ui</param>
        /// <param name="name">the name of the custom ui</param>
        public static void ElementHookUI<T, Target>(Action<T> uiConstructor, string name) where T : HUDComponent where Target : HUDComponent
        {
            elementHooks.Add(new ElementHook() { target = typeof(Target), uiType = typeof(T), uiConstructor = component => uiConstructor.Invoke((T)component), name = name });
        }
        /// <summary>
        /// hook the ui constructor to be able to add elements to it
        /// </summary>
        /// <param name="target">the target type</param>
        /// <param name="constructor">use this to add elements to the ui</param>
        public static void HookUIConstructor(Type target, Action<HUDComponent> constructor)
        {
            constructorHooks.Add(new ConstructorHooks() { target = target, constructor = constructor });
        }
        /// <summary>
        /// hook the ui constructor to be able to add elements to it
        /// </summary>
        /// <typeparam name="T">the type to add</typeparam>
        /// <param name="constructor">use this to add elements to the ui</param>
        public static void HookUIConstructor<T>(Action<T> constructor) where T : HUDComponent
        {
            constructorHooks.Add(new ConstructorHooks() { target = typeof(T), constructor = component => constructor.Invoke((T)component) });
        }
        /// <summary>
        /// will run a function when safe to load all ui resources
        /// </summary>
        /// <param name="func">the function to run</param>
        public static void HookLateStart(Action func)
        {
            lateStartHooks.Add(func);
        }
        public class ElementHook
        {
            public Type target;
            public Type uiType;
            public Action<HUDComponent> uiConstructor;
            public string name;
        }
        public class ConstructorHooks
        {
            public Type target;
            public Action<HUDComponent> constructor;
        }
    }
}
