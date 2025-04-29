using UnityEngine;

public class AstroidMovement : MonoBehaviour
{
    public float speed = 1f; 
    public float radius = 3f; 

    void Update()
    {
        float t = Time.time * speed;
        float x = radius * Mathf.Pow(Mathf.Cos(t), 3);
        float z = radius * Mathf.Pow(Mathf.Sin(t), 3);
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
