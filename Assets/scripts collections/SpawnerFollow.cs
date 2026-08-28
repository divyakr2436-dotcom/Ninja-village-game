using UnityEngine;

public class SpawnerFollow : MonoBehaviour
{
    public Transform player;
    public float distanceAhead = 30f;

    void Update()
    {
        transform.position = new Vector3(
            0,
            transform.position.y,
            player.position.z + distanceAhead
        );
    }
}