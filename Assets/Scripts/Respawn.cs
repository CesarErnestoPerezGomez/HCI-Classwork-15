using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float thresholdY = -20f; 

    private Vector3 startingPosition;
    private Rigidbody rb;
    private Rigidbody2D rb2D;

    void Start()
    {
        startingPosition = transform.position;
        
        rb = GetComponent<Rigidbody>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < thresholdY)
        {
            ReturnToStart();
        }
    }

    void ReturnToStart()
    {
        if (rb != null) rb.linearVelocity = Vector3.zero; 
        if (rb2D != null) rb2D.linearVelocity = Vector2.zero;
        
        transform.position = startingPosition;
    }
}