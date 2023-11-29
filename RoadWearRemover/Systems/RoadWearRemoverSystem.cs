using Game;
using Game.Audio;
using Game.Prefabs;
using Game.Rendering;
using Game.Simulation;
using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace RoadWearRemover.Systems
{
    public class RoadWearRemoverSystem : GameSystemBase
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            Shader shader = Shader.Find("BH/Decals/CurvedDecalDeteriorationShader");
            World.GetExistingSystemManaged<RenderingSystem>().SetShaderEnabled(shader, false);
        }

        protected override void OnUpdate() { }
    }
}
