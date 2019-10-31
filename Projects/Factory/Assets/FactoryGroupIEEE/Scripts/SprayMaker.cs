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
		private int ProjectileCount = 12;
		private float VelocityStep;

		void Start()
		{
			if (ProjectileCount == 1)
				VelocityStep = 0.0f;
			else
				VelocityStep = 2.0f / (ProjectileCount - 1);
			//Debug.Log(VelocityStep.ToString());
		}

		public GameObject Make()
		{
			GameObject newObject;

			/*
			newObject = Instantiate(this.prefab, this.gameObject.transform);
			var firstObjectMotion = newObject.GetComponent<SprayMotion>();
			firstObjectMotion.SetZSpeed(VelocityStep, 0);
			Destroy(newObject, 5.0f);
			*/
			for (int i = 0; i < ProjectileCount; i++)
			{
				newObject = Instantiate(this.prefab, this.gameObject.transform);
				var objectMotion = newObject.GetComponent<SprayMotion>();
				objectMotion.SetZSpeed(VelocityStep, i);
				Destroy(newObject, 5.0f);
			}
			newObject = GameObject.Find("SprayBullet");
			return newObject;
		}
	}
}