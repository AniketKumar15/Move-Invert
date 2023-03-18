using UnityEngine;

public class NextTile : MonoBehaviour
{
    

    private void Start()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        GroundSpwaner.FindObjectOfType<GroundSpwaner>().tileSpawner();
        Destroy(gameObject, 3f);
    }

   

    
}
