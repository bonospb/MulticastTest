using Morpeh;
using Multicast.Test.ECS.Components;
using UnityEngine;

namespace Multicast.Test.ECS.Systems
{
    [CreateAssetMenu(menuName = "ECS/Systems/" + nameof(InputSystem))]
    public sealed class InputSystem : ISystem, IInitializer
    {
        #region Private
        private Filter filter;
        #endregion

        #region Implementation
        public World World { get; set; }

        public void OnAwake() =>
            filter = World.Filter.With<Unit>().With<MoveDirection>();

        public void OnUpdate(float deltaTime)
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            var direction = new Vector3(horizontal, 0, vertical);

            foreach (var entity in filter)
            {
                ref var moveDirection = ref entity.GetComponent<MoveDirection>();
                moveDirection.Direction = direction;
            }
        }

        public void Dispose() { }
        #endregion
    }
}