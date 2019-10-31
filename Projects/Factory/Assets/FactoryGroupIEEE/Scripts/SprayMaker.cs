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
		[SerializeField]
		private float Duration = 7.5f;
		private float VelocityStep;
		
		void Start()
		{
			if (ProjectileCount == 1)
				VelocityStep = 0.0f;
			else
				VelocityStep = 2.0f / (ProjectileCount - 1);
		}

		public GameObject Make()
		{
			GameObject newObject;
			
			for (int i = 0; i < ProjectileCount; i++)
			{
				newObject = Instantiate(this.prefab, this.gameObject.transform);
				var objectMotion = newObject.GetComponent<SprayMotion>();
				objectMotion.SetZSpeed(VelocityStep, i);
				Destroy(newObject, Duration);
			}

			// Since many bullets were created, I'll just have it return any bullet.
			newObject = GameObject.Find("SprayBullet");
			return newObject;
		}
	}
}