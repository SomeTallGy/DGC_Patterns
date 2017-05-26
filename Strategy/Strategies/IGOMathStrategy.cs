using UnityEngine;
using System.Collections.Generic;

namespace Patterns.Strategy
{
    public enum GOMathType{ Add, Subtract, Multiply }
    public interface IGOMathStrategy
    {	
		  bool Apply(ref List<GameObject> gameObjects, int n);
    }
}