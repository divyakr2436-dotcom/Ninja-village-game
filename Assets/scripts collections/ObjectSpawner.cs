using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject[] prefabs;   // 0 = Diamond, 1 = Bomb

    [Header("player")]
    public Transform player;

    [Header("Spawn Settings")]
    public float spawnInterval = 2f;
    public float spawnDistance = 30f;
    public float spawnHeight = 0.5f;

    [Header("Lane Settings")]
    public float laneDistance = 2f;   // Distance between lanes

    void Start()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("player").transform;

        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }

    void SpawnObject()
    {
        // Random lane: Left (-1), Center (0), Right (1)
        int lane = Random.Range(-1, 2);

        float xPos = lane * laneDistance;

        Vector3 spawnPos = new Vector3(
            xPos,
            spawnHeight,
            player.position.z + spawnDistance
        );

        int randomPrefab = Random.Range(0, prefabs.Length);

        Instantiate(prefabs[randomPrefab], spawnPos, Quaternion.identity);
    }
}