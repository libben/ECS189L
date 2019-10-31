using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayMotion : MonoBehaviour
{
	[SerializeField]
	private float XSpeed = 5.0f;
	private float ZSpeed { get; set; }

	void Start()
	{
		//ZSpeed = Random.Range(-1.0f, 1.0f) * XSpeed;
	}

	public void SetZSpeed(float step, int num)
	{
		ZSpeed = XSpeed * (1.0f - step * num);
	}

	void Update()
	{
		var pos = this.transform.position;
		pos.x = pos.x + this.XSpeed * Time.deltaTime;
		pos.z = pos.z + this.ZSpeed * Time.deltaTime;
		this.transform.position = pos;
	}
}
