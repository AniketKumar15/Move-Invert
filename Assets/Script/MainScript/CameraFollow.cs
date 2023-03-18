using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    public Vector3 offset; //offset value which is vector
   

    private void Start()
    {
        //Find the player by it tag and add with camera
        player = GameObject.FindGameObjectWithTag("Player");

    }
    private void Update()
    {
        //Get the player position and the offset value to follow the player by camera
        transform.position = player.transform.position + offset;
    }

}
