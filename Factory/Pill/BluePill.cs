using UnityEngine;

namespace Patterns.Factory
{
    public class BluePill : Pill
    {
        public override Color Color { get { return Color.blue; } }

        public BluePill(GameObject prefab, Vector3 position) : base(prefab, position)
        {

        }
    }
}