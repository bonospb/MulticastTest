using Morpeh;
using Multicast.Test.Configurations;
using System;
using UnityEngine;

namespace Multicast.Test.ECS.Components
{
    [Serializable]
    public struct Unit : IComponent
    {
        public UnitConfig Config;
        public Rigidbody Rigidbody;
    }
}
