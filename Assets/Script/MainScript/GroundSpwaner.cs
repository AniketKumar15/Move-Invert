using UnityEngine;

public class GroundSpwaner : MonoBehaviour
{
    
    public GameObject[] groundTiles; //Get the tile and spawn it
    public Vector3 spawnPoint; //A vector type of dataType to check the positon of the next tile

    
    // Start is called before the first frame update
    void Start()
    {
        //A loop which instantiate the 15 griund tile 
        for (int i = 0; i < 15; i++)
        {
            tileSpawner();  
        }
        
    }
    //Instantiate the ground tile 
    public void tileSpawner()
    {
        GameObject temp = Instantiate(groundTiles[Random.Range(0,14)], spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(1).transform.position;
    }
   
}
