using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTween : MonoBehaviour
{
    [SerializeField] private float duracion;
    [SerializeField] AnimationCurve ease;
    [SerializeField] Transform target;
  
    private bool isPlaying=  false;
    private float acumulateTime = 0;
    private Vector3 posicionInicial;

    void Start()
    {
        Debug.Assert(target != null, "Sin target");
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            acumulateTime = 0;
            isPlaying = true;
            posicionInicial = transform.position;
        }
        if (!isPlaying) return;

        float t = acumulateTime/duracion;
        transform.position = Vector3.LerpUnclamped(posicionInicial, target.position, ease.Evaluate(t));
        acumulateTime += Time.deltaTime;

        if (t >= 1) {
            isPlaying = false;
            Debug.Log("hola");
        }
        
    }
}
