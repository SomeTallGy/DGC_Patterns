using UnityEngine;
using DG.Tweening;

namespace Patterns.Command
{
    public class Sphere : MonoBehaviour
    {
        private Tween tween;

        public void UpdateColor(Color color)
        {
            MeshRenderer renderer = this.GetComponent<MeshRenderer>();
            if (tween != null) tween.Complete();
            renderer.material.color = color;
            tween = renderer.material.DOColor(Color.black, 1.0f);
            // renderer.transform.GetComponent<Rigidbody>().AddForce(this.transform.up * 2, ForceMode.Impulse);
        }
    }
}
