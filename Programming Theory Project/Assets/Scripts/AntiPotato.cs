using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiPotato : Potato // INHERITANCE
{
    public override void Destroy() // POLYMORPHISM
    {
        //Debug.Log("Anti Potato Destroy");
        PlayerManager.PlayerInstance.ship.HPChanger(damage);
        Destroy(gameObject);
    }

    public override void DestroyNoScore() // POLYMORPHISM
    {
        PlayerManager.PlayerInstance.ship.ChangeScore(value);
        Destroy(gameObject);
    }
}
