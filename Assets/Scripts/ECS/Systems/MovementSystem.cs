using Morpeh;
using Multicast.Test.ECS.Components;
using UnityEngine;

namespace Multicast.Test.ECS.Systems
{
    [CreateAssetMenu(menuName = "ECS/Systems/" + nameof(MovementSystem))]
    public sealed class MovementSystem : IFixedSystem
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
            foreach (var entity in filter)
            {
                ref var unit = ref entity.GetComponent<Unit>();
                ref var moveDirection = ref entity.GetComponent<MoveDirection>();

                Vector3 direction = moveDirection.Direction;
                Vector3 velocity = unit.Config.Speed * direction;

                unit.Rigidbody.velocity = velocity;
                unit.Rigidbody.angularVelocity = Vector3.zero;

                if (direction.sqrMagnitude <= 0f)
                    return;

                unit.Rigidbody.rotation = Quaternion.LookRotation(direction, Vector3.up);
            }
        }

        public void Dispose() { }
        #endregion
    }
}