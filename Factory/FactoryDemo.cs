using UnityEngine;
using DG.Tweening;

namespace Patterns.Factory
{
    public class FactoryDemo : MonoBehaviour
    {
		// ------ inspector fields ------
		public GameObject pillPrefab;
		public GameObject factoryGameObject;
        public Transform emitter;

		// ------- private fields -------
		private PillFactory factory;
		private Tween tween;

        // Use this for initialization
        void Start()
        {
			factory = new PillFactory(pillPrefab, emitter);
        }

		void OnGUI()
        {

            if (GUI.Button(new Rect(10, 10, 150, 100), "Red Pill"))
            {
                factory.MakePill(0);
				if(tween != null) tween.Complete();
				tween = factoryGameObject.transform.DOPunchScale(new Vector3(-0.2f, -0.2f, -0.2f), 0.3f, 4);
            }
            if (GUI.Button(new Rect(170, 10, 150, 100), "Blue Pill"))
            {
                factory.MakePill(1);
				if(tween != null) tween.Complete();
				tween = factoryGameObject.transform.DOPunchScale(new Vector3(-0.2f, -0.2f, -0.2f), 0.3f, 4);
            }
            if (GUI.Button(new Rect(330, 10, 150, 100), "Random Pill"))
            {
                factory.MakePill();
				if(tween != null) tween.Complete();
				tween = factoryGameObject.transform.DOPunchScale(new Vector3(-0.2f, -0.2f, -0.2f), 0.3f, 4);
            }

			

        }
    }
}