using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Text timeText;
    [SerializeField] Slider slider;
    // time in seconds not minutes
    public GameObject Object;

    public float startTime = 6;
    public bool stahp = true;
    private float currentTime = 0.0f;
    private float currentTimeHours = 0.0f;
    private float currentTimeSeconds = 0.0f;


    public void Start()
    {
       
        Object.SetActive(true);
        slider.value = 0;
        currentTime = startTime;
    }

    // Update is called once per frame
    public void Update()
    {
        if (currentTime <= 1)
        {

            stahp = false;
            currentTime = 0.0f;
            slider.value = 1;


            Object.SetActive(false);

        }
      
       
        if (stahp) {
            slider.value += Time.deltaTime/startTime;
            //val += (float) Time.deltaTime;
        currentTime -= Time.deltaTime;
            currentTimeHours = currentTime / 60;
        currentTimeSeconds = (currentTime%60)-1;
           //currentTimeSeconds -= Time.fixedDeltaTime;
        timeText.text = currentTimeHours.ToString("00") + ":" + currentTimeSeconds.ToString("00");
    }
       
    }
}
