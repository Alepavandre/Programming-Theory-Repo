using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Ship : Body
{
    public Text hpText;
    public float distance = 50f;
    public Text scoresText;
    private int scores = 0;
    private new Camera camera;

    void Start()
    {
        hp = hpMax;
        camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }
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

        if (Physics.Raycast(ray, out RaycastHit hit, distance))
        {
            Potato potato = hit.collider.GetComponent<Potato>();
            if (potato != null)
            {
                potato.HPChanger(damage);
                //potato.Destroy();
            }
        }
    }

    public override void HPChanger(int count)
    {
        base.HPChanger(count);
        hpText.text = hp.ToString() + " hp";
    }

    public override void Destroy()
    {
        //Debug.Log("Ship Destroy");
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    void OnTriggerEnter(Collider col)
    {
        Potato potato = col.GetComponent<Potato>();
        if (potato != null)
        {
            //HPChanger(potato.damage);
            potato.DestroyNoScore();
        }
    }

    public void ChangeScore(int count)
    {
        scores += count;
        scoresText.text = "Chips: " + scores.ToString();
    }
}
