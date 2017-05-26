using UnityEngine;

namespace Patterns.Factory
{
    public class RedPill : Pill
    {
        public override Color Color { get { return Color.red; } }

        public RedPill(GameObject prefab, Vector3 position) : base(prefab, position)
        {

        }
    }
}