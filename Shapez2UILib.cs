using Core.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Shapez2UILib
{
    public class Shapez2UILib : IMod
    {
        public static ILogger logger;
        private readonly Harmony harmony;
        public Shapez2UILib(ILogger logger)
        {
            Shapez2UILib.logger = logger;
            harmony = new Harmony("bknibb.Shapez2UILib");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            harmony.PatchAll(typeof(MainMenuUIRegistrar));
        }
        public void Dispose()
        {
            harmony.UnpatchSelf();
        }
    }
}
