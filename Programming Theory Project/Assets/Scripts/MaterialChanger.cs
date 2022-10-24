using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
	public Color color1;
	public Color color2;
	public Material material;
	//public Material skyMat;
	public float period = 1.0f;
	public Vector3 disp;
	public float intensity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (!DataManager.Instance.pause){
			Color color = new Color (Mathf.Lerp(color1.r, color2.r, Mathf.Abs(Mathf.Sin(period * Time.time + disp.x))),
			Mathf.Lerp(color1.g, color2.g, Mathf.Abs(Mathf.Sin(period * Time.time + disp.y))),
			Mathf.Lerp(color1.b, color2.b, Mathf.Abs(Mathf.Sin(period * Time.time + disp.z))));
			//float curIntensity = material.GetColor("_EmissionColor").grayscale;
			//Debug.Log(curIntensity);
			material.SetColor("_EmissionColor", color * intensity);
			//skyMat.SetColor("_Tint", color);
			//material.SetFloat("_EmissionIntensity", intensity);
		}
    }
}
