using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _speedScale;

    void FixedUpdate()
    {
        transform.Translate(transform.forward * _speedMove);
        transform.Rotate(transform.up * _speedRotate);
        transform.localScale += Vector3.one * _speedScale;
    }
}
