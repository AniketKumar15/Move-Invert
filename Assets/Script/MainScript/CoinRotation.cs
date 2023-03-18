using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public Vector3 rotationCoin; // vector type data type
    public float rotationSpeed; 

    // Update is called once per frame
    void Update()
    {
        //rotate the coin to the given axis and mulityplay with rotationaSpeed
        transform.Rotate(rotationCoin * rotationSpeed * Time.deltaTime);

    }
}
