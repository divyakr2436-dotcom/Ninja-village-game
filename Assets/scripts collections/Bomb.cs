using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("Game Over - hit by bomb");

            if (GameManager.Instance != null)
                GameManager.Instance.GameOver();
            else
                Debug.Log("GameManager.Instance is null!");

            gameObject.SetActive(false);
        }
    }
}