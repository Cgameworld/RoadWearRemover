using Colossal.UI;
using Game;
using Game.Audio;
using Game.SceneFlow;
using Game.UI.Menu;
using HarmonyLib;
using RoadWearRemover.Systems;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace RoadWearRemover.Patches
{

    [HarmonyPatch(typeof(AudioManager), "OnGameLoadingComplete")]
    internal class AudioManager_OnGameLoadingComplete
    {
        static void Postfix(AudioManager __instance, Colossal.Serialization.Entities.Purpose purpose, GameMode mode)
        {
            if (!mode.IsGameOrEditor())
                return;

            // Here we add our custom ECS System to the game's ECS World, so it's "online" at runtime
            __instance.World.GetOrCreateSystem<RoadWearRemoverSystem>();
        }
    }
}