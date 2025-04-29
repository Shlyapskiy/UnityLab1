using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float speed = 2f;  
    public float angle = 45f; 

    void Update()
    {
        float zRotation = angle * Mathf.Sin(Time.time * speed);
        transform.localRotation = Quaternion.Euler(0, 0, zRotation);
    }
}
