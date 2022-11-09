using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenu : UI // INHERITANCE
{
	[SerializeField]
	private GameObject menu;
	[SerializeField]
	private Slider slider;

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
			if (!menu.activeSelf)
			{
				menu.SetActive(true);
				DataManager.Instance.pause = true;
				Cursor.lockState = CursorLockMode.None;
				Time.timeScale = 0f;
			}
            else
            {
				Continue();
            }
        }
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
