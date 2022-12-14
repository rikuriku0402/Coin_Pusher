using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DownMove : MonoBehaviour
{
    [SerializeField]
    [Header("落ちてくるやつの横移動")]
    float _xMove;

    private void Start()
    {
        this.transform.DOLocalMoveX(_xMove, 2f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetRelative()
            .SetEase(Ease.Linear);

    }
}
