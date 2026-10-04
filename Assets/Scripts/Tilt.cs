using UnityEngine;

public class Tilt : MonoBehaviour
{
    public float maxAngle = 10f; 
    public float velocity = 0.5f;     

    void Update()
    {
        float angle = Mathf.Sin(Time.time * velocity) * maxAngle;
        
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
