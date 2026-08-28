using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float laneDistance = 2f;

    private int currentLane = 1; // 0 = Left, 1 = Center, 2 = Right

    void Update()
    {
        // Move Left
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentLane > 0)
                currentLane--;
        }

        // Move Right
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentLane < 2)
                currentLane++;
        }

        Vector3 position = transform.position;
        position.x = (currentLane - 1) * laneDistance;
        transform.position = position;
    }
}