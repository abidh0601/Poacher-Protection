using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameRateCounter : MonoBehaviour
{
    private int frameCounter = 0;
    private float TimeCounter = 0.0f;
    private float refreshTime = 0.1f;

    [SerializeField] private Text frameText;
   
    // Update is called once per frame
    void Update()
    {
        if(TimeCounter < refreshTime)
        {
            TimeCounter += Time.deltaTime;
            frameCounter++;
        }    
        else
        {
            float lastFrameRate = frameCounter / TimeCounter;
            frameCounter = 0;
            TimeCounter = 0.0f;

            frameText.text = "FPS: " + lastFrameRate.ToString("0");
        }
    }
}
