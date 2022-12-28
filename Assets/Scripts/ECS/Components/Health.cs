using Morpeh;
using System;

namespace Multicast.Test.ECS.Components
{
    [Serializable]
    public struct Health : IComponent
    {
        public float Value;
    }
}
