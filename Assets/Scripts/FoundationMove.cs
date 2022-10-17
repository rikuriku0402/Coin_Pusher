using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FoundationMove : MonoBehaviour
{
    [SerializeField]
    [Header("ZŽ²‚Ì“®‚«")]
    float _zMove;

    void Start()
    {
        this.transform.DOLocalMoveZ(_zMove, 2f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetRelative()
            .SetEase(Ease.Linear);
    }
}
