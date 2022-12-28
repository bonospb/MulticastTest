using Morpeh;
using System;
using UnityEngine;

namespace Multicast.Test.ECS.Components
{
    [Serializable]
    public struct MoveDirection : IComponent
    {
        public Vector3 Direction;
    }
}
