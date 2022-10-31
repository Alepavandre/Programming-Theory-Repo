using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Potato>() != null)
		{
			Destroy(col.gameObject);
		}
	}
}
