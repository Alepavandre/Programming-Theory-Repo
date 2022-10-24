using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public Transform parent;
	public Transform spawnPlace;
	public GameObject asteroid;
	public float delay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	IEnumerator Spawn()
	{
		while (true)
		{
			if (!DataManager.Instance.pause)
			{
				Vector3 pos = spawnPlace.position + new Vector3(0f, Random.Range(-5f, 5f), Random.Range(-5f, 5f));
				Instantiate(asteroid, pos, transform.rotation, parent);
			}
			yield return new WaitForSeconds(delay);
		}
	}
}
