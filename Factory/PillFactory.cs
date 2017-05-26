using UnityEngine;

namespace Patterns.Factory
{
    public class PillFactory
    {
		private GameObject prefab;
		private Transform emitter;

		public PillFactory(GameObject prefab, Transform emitter)
		{
			this.prefab = prefab;
			this.emitter = emitter;
		}

        public Pill MakePill(int n = -1)
        {
			switch(n){
				case 0:
					return new RedPill(prefab, emitter.position);
				case 1:
					return new BluePill(prefab, emitter.position);
				case -1:
				default:
					// return a random pill;
					return MakePill(Random.Range((int)0, (int) 2));
			}
        }
    }
}