using UnityEngine;
using System.Collections.Generic;

namespace Patterns.Strategy
{
    public class Multiply : IGOMathStrategy
    {   
        public bool Apply(ref List<GameObject> gameObjects, int n)
        {
            if (gameObjects != null)
            {
                if (gameObjects.Count > 0 && gameObjects.Count <= StrategyDemo.MAX_GO / 2)
                {
                    // 1. Validate n
                    n = (gameObjects.Count * n) / 2;

                    // 2. Get mother GameObject
                    GameObject gameObject = gameObjects[0];

                    // 3. Create new GameObjects
                    for (int i = 0; i < n; i++)
                    {
                        gameObjects.Add(GameObject.Instantiate(gameObject, Vector3.zero, Quaternion.identity));
                    }

                    // 4. Success!
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}