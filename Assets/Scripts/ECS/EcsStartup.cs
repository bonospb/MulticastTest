using Morpeh;
using Multicast.Test.ECS.Systems;
using UnityEngine;

namespace Multicast.Test.ECS
{
    public class EcsStartup : MonoBehaviour
    {
        #region Private
        private World world;

        private SystemsGroup fixedUpdateSystems;
        private SystemsGroup updateSystems;
        #endregion

        #region Unity methods
        private void Awake() =>
            Construct();

        private void OnDestroy() =>
            Destruct();
        #endregion

        #region Public methods
        public void Construct()
        {
            world = World.Create();

            fixedUpdateSystems = world.CreateSystemsGroup();
            fixedUpdateSystems.AddSystem(new MovementSystem());

            updateSystems = world.CreateSystemsGroup();
            updateSystems.AddSystem(new InputSystem());

            world.AddSystemsGroup(order: 0, fixedUpdateSystems);
            world.AddSystemsGroup(order: 1, updateSystems);
        }

        public void Destruct()
        {
            world.RemoveSystemsGroup(updateSystems);
            updateSystems = null;

            world.RemoveSystemsGroup(fixedUpdateSystems);
            fixedUpdateSystems = null;

            world = null;
        }
        #endregion
    }
}
