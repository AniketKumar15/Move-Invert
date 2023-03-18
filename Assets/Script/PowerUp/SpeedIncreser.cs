using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreser : MonoBehaviour
{
    public float powerUpTime;
    public float counter;
    public bool isPowerUp = false;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            
            StartCoroutine(SpeedAdd());
            
        }
    }

    IEnumerator SpeedAdd()
    {
        PlayerMovement.FindObjectOfType<PlayerMovement>().forwardSpeed = 4000;
        isPowerUp = true;
        yield return new WaitForSeconds(powerUpTime);
        isPowerUp = false;

        PlayerMovement.FindObjectOfType<PlayerMovement>().forwardSpeed = 3000;
    }
    
    
}
