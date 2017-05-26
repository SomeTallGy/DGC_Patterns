using UnityEngine;
using System.Collections.Generic;

namespace Patterns.Command
{
    public class CommandableSpheres : MonoBehaviour, ICommandable
    {
        // -------- inspector fields ---------
        public Sphere redSphere;
        public Sphere blueSphere;
        public Sphere greenSphere;
        public Sphere yellowSphere;

        // ------- private fields ------------
        private Dictionary<Color, Sphere> spheres = new Dictionary<Color, Sphere>();

        void Start()
        {
            spheres[Color.red] = redSphere;
            spheres[Color.blue] = blueSphere;
            spheres[Color.green] = greenSphere;
            spheres[Color.yellow] = yellowSphere;
        }

        public void UpdateColor(Color color)
        {
            spheres[color].UpdateColor(color);
        }
    }
}