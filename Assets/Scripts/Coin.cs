using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IGet, ILost
{
    public void Get()
    {
        print("get");
    }

    public void Lost()
    {
        print("lost");
    }
}
