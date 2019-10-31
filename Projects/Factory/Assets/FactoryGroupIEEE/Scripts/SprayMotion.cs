using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayMotion : MonoBehaviour
{
	[SerializeField]
	private float XSpeed = 5.0f;
	private float YSpeed;

	void Start()
	{
		YSpeed = Random.Range(-3.0f, 3.0f);
	}

	void Update()
	{
		var pos = this.transform.position;
		pos.x = pos.x + this.XSpeed * Time.deltaTime;
		pos.y = pos.y + this.YSpeed * Time.deltaTime;
		this.transform.position = pos;
	}
}
