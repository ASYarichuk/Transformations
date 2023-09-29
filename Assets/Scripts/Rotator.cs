using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        transform.Rotate(transform.up * _speed);
    }
}
