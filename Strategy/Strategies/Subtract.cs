using UnityEngine;
using System.Collections.Generic;

namespace Patterns.Strategy
{
    public class Subtract : IGOMathStrategy
    {   
        public bool Apply(ref List<GameObject> gameObjects, int n)
        {
            if (gameObjects != null)
            {
                if (gameObjects.Count > StrategyDemo.MIN_GO)
                {   
                    // 1. Validate n
                    if(n > gameObjects.Count)
                        n = gameObjects.Count;

                    // 2. Get gameObjects to destroy (subtract)
                    List<GameObject> toDestroy = gameObjects.GetRange(0, n);

                    // 3. Destroy gameObjects in toDestroy
                    foreach(var go in toDestroy)
                    {
                        GameObject.Destroy(go);
                    }
                    
                    // 4. Update List
                    gameObjects.RemoveRange(0, n);

                    // 5. Success!
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