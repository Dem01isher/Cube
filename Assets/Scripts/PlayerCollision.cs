using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Text gameOver;
    public Button restartButton;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            restartButton.gameObject.SetActive(true);
            gameOver.gameObject.SetActive(true);
            Debug.Log("We hit " + collision.collider.name);
        }
    }

    private void FixedUpdate()
    {
        if (movement.transform.position.y < -5)
        {
            movement.enabled = false;
            restartButton.gameObject.SetActive(true);
            gameOver.gameObject.SetActive(true);
        }
    }
        
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
}
