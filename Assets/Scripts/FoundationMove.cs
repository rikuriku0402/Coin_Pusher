using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FoundationMove : MonoBehaviour
{
    #region dotween‚Å“®‚©‚µ‚½ê‡

    [SerializeField]
    [Header("Z²‚Ì“®‚«")]
    float _zMove;

    void Start()
    {
        this.transform.DOLocalMoveZ(_zMove, 2f)
            .SetLoops(-1, LoopType.Yoyo)
            //.SetRelative()
            .SetEase(Ease.Linear);
    }

    #endregion

    //int _counter = 0;
    //[SerializeField]
    //[Header("Z²‚Ì“®‚«")]
    //float _move = 0.05f;

    //void Update()
    //{
    //    Vector3 p = new Vector3(0f, 0f, _move) * 0.5f;
    //    transform.Translate(p);
    //    _counter++;

    //    //count‚ª100‚É‚È‚ê‚Î-1‚ğŠ|‚¯‚Ä‹t•ûŒü‚É“®‚©‚·
    //    if (_counter == 100)
    //    {
    //        _counter = 0;
    //        _move *= -1;
    //    }
    //}
}
