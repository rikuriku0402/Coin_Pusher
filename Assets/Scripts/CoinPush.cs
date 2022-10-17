using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class CoinPush : MonoBehaviour
{
    [SerializeField]
    [Header("�R�C��")]
    GameObject _coin;

    [SerializeField]
    [Header("�R�C���������Ă���ꏊ")]
    GameObject _coinDown;

    private void Start()
    {
        this.UpdateAsObservable().Subscribe(x => CoinInstantiate());
    }

    void CoinInstantiate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_coin, _coinDown.transform.position, Quaternion.identity);
        }
    }
}
