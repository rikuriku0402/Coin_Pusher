using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLost : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out ILost lost))
        {
            lost.Lost();
        }
    }
}
