using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
	[SerializeField]
	private Material material;
	[SerializeField]
	private float period = 1.0f;
	[SerializeField]
	private Vector3 intensity;

    void Update()
    {
		if (!DataManager.Instance.pause)
		{
			float k = 2 * Mathf.PI / period;
			float r = (Mathf.Sin(k * Time.time) + 1f) * intensity.x / 2f;
			float g = (Mathf.Sin(k * Time.time + 4f * Mathf.PI / 3f) + 1f) * intensity.y / 2f;
			float b = (Mathf.Sin(k * Time.time + 2f * Mathf.PI / 3f) + 1f) * intensity.z / 2f;
			Color color = new Color(r, g, b);
			material.SetColor("_EmissionColor", color);
		}
    }
}
