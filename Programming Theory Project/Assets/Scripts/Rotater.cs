using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
	[SerializeField]
	private Vector3 speed;

	// Update is called once per frame
	void FixedUpdate()
	{
		
		if (!DataManager.Instance.pause)
		{
			transform.Rotate(speed.x, speed.y, speed.z);
		}
		speed *= DataManager.Instance.accelerate;
	}
}
