using Morpeh;
using Multicast.Test.ECS.Components;
using UnityEngine;

namespace Multicast.Test.ECS.Providers
{
    [AddComponentMenu("Tanks/Health")]
    public sealed class HealthProvider : MonoProvider<Health>
    {
    }
}
