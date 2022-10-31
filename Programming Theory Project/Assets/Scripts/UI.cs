using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class UI : MonoBehaviour
{
    private void Start()
    {
		Time.timeScale = 1f;
		DataManager.Instance.pause = false;
	}

    public void Quit()
	{
		Application.Quit();
	}

	public void StartLevel()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}

	public void MainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}
}
