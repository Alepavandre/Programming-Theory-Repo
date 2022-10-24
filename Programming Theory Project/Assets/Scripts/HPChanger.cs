using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPChanger : MonoBehaviour
{
	public Text hpText;
	private int hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter(Collider col)
	{
		//Debug.Log(col.gameObject.name);
		Destroy(col.gameObject);
		HPChange(30);
	}
	
	private void HPChange(int damage)
	{
		hp -= damage;
		if (hp <= 0)
		{
			hp = 0;
			GameOver();
		}
		hpText.text = hp.ToString() + " hp";
	}
	
	private void GameOver()
	{
		SceneManager.LoadScene(0);
	}
}
