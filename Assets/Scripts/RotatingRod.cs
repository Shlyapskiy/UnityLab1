using UnityEngine;

public class RotatingRod : MonoBehaviour
{
    public float rotationSpeed = 50f; 

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
