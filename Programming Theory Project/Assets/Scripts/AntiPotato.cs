using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiPotato : Potato
{
    public override void Destroy()
    {
        //Debug.Log("Anti Potato Destroy");
        PlayerManager.PlayerInstance.ship.HPChanger(damage);
        Destroy(gameObject);
    }

    public override void DestroyNoScore()
    {
        PlayerManager.PlayerInstance.ship.ChangeScore(value);
        Destroy(gameObject);
    }
}
