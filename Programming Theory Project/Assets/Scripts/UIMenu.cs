using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
	public GameObject menu;
	public Slider slider;

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(true);
			DataManager.Instance.pause = true;
			Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0f;
        }
    }
	
	public void Quit()
	{
		Application.Quit();
	}
	
	public void Continue()
	{
		menu.SetActive(false);
		DataManager.Instance.pause = false;
		Cursor.lockState = CursorLockMode.Locked;
		Time.timeScale = 1f;
	}
	
	public void ChangeSens()
	{
		DataManager.Instance.sensValue = slider.value;
	}
}
