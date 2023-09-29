using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        transform.Translate(transform.forward * _speed);
    }
}
