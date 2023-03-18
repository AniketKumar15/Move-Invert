using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TImer : MonoBehaviour
{
    public float currentTime;
    public float maxTime;
    public Slider powerUpSlider;
    public GameObject powerUpSliderObj;

    private void Start()
    {
        currentTime = maxTime;
        powerUpSliderObj.SetActive(false);
    }
    

    public void CountDown()
    {
        currentTime -= 1 * Time.deltaTime;
        powerUpSlider.value = currentTime;

    }
}
