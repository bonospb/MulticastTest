using UnityEngine;

namespace Multicast.Test.Configurations
{
    [CreateAssetMenu(fileName = "TankConfig", menuName = "Tanks/TankConfiguration", order = 0)]
    public sealed class UnitConfig : ScriptableObject
    {
        public float Speed = 0f;
    }
}