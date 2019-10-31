using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IEEE
{
	public class SprayMaker : MonoBehaviour, IFactorySpell
	{
		[SerializeField]
		private GameObject prefab;
		[SerializeField]
		private int number = 12;

		void Start()
		{
		}

		public GameObject Make()
		{
			GameObject newObject;
			for (int i = 0; i < number - 1; i++)
			{
				newObject = Instantiate(this.prefab, this.gameObject.transform);
			}
			newObject = Instantiate(this.prefab, this.gameObject.transform);
			return newObject;
		}
	}
}