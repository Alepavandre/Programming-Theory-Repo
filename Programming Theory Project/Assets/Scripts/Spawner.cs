using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct PotatoObject
{
	public GameObject prefab;
	public int freq;
}

public class Spawner : MonoBehaviour
{
	public Transform parent;
	public Transform spawnPlace;
	private GameObject[] potato;
	public PotatoObject[] potatoObjects;
	public float delay = 0.5f;
	public float range = 2f;
    // Start is called before the first frame update
    void Start()
    {
		int n = 0;
		foreach (var potatoObject in potatoObjects)
        {
			n += potatoObject.freq;
        }
		//Debug.Log(n);
		potato = new GameObject[n];
		int m = 0;
		foreach (var potatoObject in potatoObjects)
		{
			for (int i = m; i < m + potatoObject.freq; i++)
            {
				potato[i] = potatoObject.prefab;
				//Debug.Log("i = " + i.ToString());
            }
			m += potatoObject.freq;
			//Debug.Log("m = " + m.ToString());
		}
		StartCoroutine("Spawn");
    }
	
	IEnumerator Spawn()
	{
		while (true)
		{
			if (!DataManager.Instance.pause)
			{
				Vector3 pos = spawnPlace.position + new Vector3(0f, Random.Range(-range, range), Random.Range(-range, range));
				Instantiate(potato[Random.Range(0, potato.Length)], pos, transform.rotation, parent);
			}
			yield return new WaitForSeconds(delay);
		}
	}
}
