using Morpeh;
using Multicast.Test.ECS.Components;
using UnityEngine;

namespace Multicast.Test.ECS.Providers
{
    [AddComponentMenu("Units/Unit")]
    [RequireComponent(typeof(Rigidbody))]
    public sealed class UnitProvider : MonoProvider<Unit>
    {
    }
}