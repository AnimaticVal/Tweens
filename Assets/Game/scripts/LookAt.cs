using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LookAt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform target;
    void Start()
    {
        var seq = DOTween.Sequence();
        seq.AppendInterval(1f);
        GetComponent<Camera>().DOFieldOfView(70, 0.5f);
    }
}
