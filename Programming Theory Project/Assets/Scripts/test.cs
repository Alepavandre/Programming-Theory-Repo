using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
	public Vector3 speed;
	public Vector3 preiod;
	public Vector3 disp;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if (!DataManager.Instance.pause)
		{
			//float c = Random.Range(.0f, 1.0f);
			float a = Mathf.Sin(preiod.x * Time.time - disp.x) + 1.1f;
			float b = Mathf.Sin(preiod.y * Time.time - disp.y) + 1.1f;
			float c = Mathf.Sin(preiod.z * Time.time - disp.z) + 1.1f;
			//float a = Mathf.Exp(Mathf.Sin(Time.time * c)) / Mathf.Exp(1);
			//transform.Rotate(speed.x * a, speed.y * a, speed.z * a);
			transform.Rotate(speed.x, speed.y, speed.z);
		}
    }
}
