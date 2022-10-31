using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Body : MonoBehaviour
{
    public int hpMax = 100;
    protected int hp;
    public int damage = 30;
    void Start()
    {
        hp = hpMax;
    }

    public virtual void HPChanger(int count)
    {
        hp -= count;
        //Debug.Log(hp);
        if (hp <= 0)
        {
            hp = 0;
            Destroy();
        }
    }
    public virtual void Destroy()
    {
        Debug.Log("Body Destroy");
    }
}
