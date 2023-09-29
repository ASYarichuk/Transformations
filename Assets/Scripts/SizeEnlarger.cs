using UnityEngine;

public class SizeEnlarger : MonoBehaviour
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        transform.localScale += Vector3.one * _speed;
    }
}
