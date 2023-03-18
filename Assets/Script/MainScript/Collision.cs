using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag =="obstacle") //it is checking is player collide with obstacle or not
        {

            PlayerMovement.FindObjectOfType<PlayerMovement>().enabled = false; // Get the playerMovement Script and disable it
            GameManager.FindObjectOfType<GameManager>().GameOver(); // Get gameover method and call it.
        }
        
    }

    
}
