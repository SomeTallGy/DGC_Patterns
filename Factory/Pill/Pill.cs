using UnityEngine;

namespace Patterns.Factory
{
    abstract public class Pill
    {
        public abstract Color Color { get; }

        public Pill(GameObject prefab, Vector3 position)
        {
            // 1. create a pill gameObject
            GameObject go = GameObject.Instantiate(prefab, position, Quaternion.identity); 

            // 2. color the pill gameObject
            go.GetComponent<MeshRenderer>().material.color = Color;
        }

    }
}