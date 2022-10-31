using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : Body
{
    public int value = 10;

    public override void Destroy()
    {
        //Debug.Log("Potato Destroy");
        PlayerManager.PlayerInstance.ship.ChangeScore(value);
        Destroy(gameObject);
    }

    public virtual void DestroyNoScore()
    {
        PlayerManager.PlayerInstance.ship.HPChanger(damage);
        Destroy(gameObject);
    }

    public override void HPChanger(int count)
    {
        base.HPChanger(count);
    }
}
