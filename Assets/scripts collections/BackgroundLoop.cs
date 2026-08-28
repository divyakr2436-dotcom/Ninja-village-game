using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float roadLength = 10f;
    public float resetPosition = -10f;

    void Update()
    {
        // Move the road toward the player
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);

        // When the road goes behind the player
        if (transform.position.z <= resetPosition)
        {
            transform.position += Vector3.forward * roadLength * 3;
        }
    }
}