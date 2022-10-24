using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
	public float distance = 50f;
	public Text scoresText;
	private int scores = 0;
	private new Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
		Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !DataManager.Instance.pause)
        {
            Shot();
        }
    }
	
	private void Shot()
	{
		var ray = camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
			if (hit.collider.gameObject.CompareTag("aster"))
			{
				Destroy(hit.collider.gameObject);
				scores += 10;
				scoresText.text = "Scores: " + scores.ToString();
			}
        }
	}
}
