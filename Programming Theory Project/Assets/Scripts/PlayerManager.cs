using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager PlayerInstance { get; private set; } // ENCAPSULATION
    public Ship ship;

    private void Awake()
    {
        PlayerInstance = this;
    }
}
