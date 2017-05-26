using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Patterns.Strategy
{
    public class StrategyDemo : MonoBehaviour
    {
        // --------- constants -----------------
        public const string GIT_LINK = "https://github.com/SomeTallGy/DGC_Patterns/tree/master/Strategy";
        public const int MIN_GO = 2;
        public const int MAX_GO = 64;

        // --------- inspector fields ----------
        public GameObject prefab;
        public Text note;
        public Text coinNum;

        // --------- private fields ------------
        private List<GameObject> gameObjects = new List<GameObject>();
        private GOMathType mode = GOMathType.Add;
        private Tween tween;


        // Use this for initialization
        void Start()
        {
            // update note with min and max values
            note.text = "Minimum: " + MIN_GO + "  Maximum: " + MAX_GO;

            // start with 2
            gameObjects.Add(GameObject.Instantiate(prefab));
            gameObjects.Add(GameObject.Instantiate(prefab));
        }

        void OnGUI()
        {
            if (GUI.Button(new Rect(10, 10, 150, 100), "Addition"))
            {
                mode = GOMathType.Add;
            }
            if (GUI.Button(new Rect(170, 10, 150, 100), "Subtraction"))
            {
                mode = GOMathType.Subtract;
            }
            if (GUI.Button(new Rect(330, 10, 150, 100), "Multiplication"))
            {
                mode = GOMathType.Multiply;
            }
            if (GUI.Button(new Rect(100, 120, 100, 50), Strategy().GetType().Name + " by 2 "))
            {
                bool isSuccess = Strategy().Apply(ref gameObjects, 2);
                if (isSuccess)
                {
                    // update coinNum
                    coinNum.text = gameObjects.Count + " coins in scene";
                }
                else
                {
                    // highlight note to remind user
                    if (tween != null) tween.Complete();
                    note.color = Color.red;
                    tween = note.DOColor(Color.gray, 0.5f);
                }
            }

        }

        private IGOMathStrategy Strategy()
        {
            switch (mode)
            {
                case GOMathType.Subtract:
                    return new Subtract();
                case GOMathType.Multiply:
                    return new Multiply();
                case GOMathType.Add:
                default:
                    return new Add();
            }

        }

        public void OpenGit()
        {
            Application.OpenURL(GIT_LINK);
        }

    }
}