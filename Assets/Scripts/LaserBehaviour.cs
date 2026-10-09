using UnityEngine;

public class LaserBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 20f;

    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}