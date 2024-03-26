using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement mov;
    // public GameManager gameManager;
    void OnCollisionEnter(Collision colli_info)
    {
        if (colli_info.collider.tag == "Obstacle")
        {
            mov.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

            FindObjectOfType<AudioManager>().Play("gun");
        }
    }
}
