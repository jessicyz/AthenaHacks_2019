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
    public static float startTime = 100;
    public static bool stahp = true;
    private static float currentTime = startTime;
    public static float currentTimeHours = 0.0f;
    public static float currentTimeSeconds = 0.0f;
    public static float value = 0;

    // private static timeScript instance = null;
	// public static timeScript Instance {
	// 	get { return instance; }
	// }


    public void Start()
    {

        // if (instance != null && instance != this) {
		// 	Destroy(this.gameObject);
		// 	return;
		// } else {
		// 	instance = this;
        //     slider.value = 0;
        //     currentTime = startTime;
			
		// }

		// DontDestroyOnLoad(this.gameObject);
        
        // slider.value = 0;
        //     currentTime = startTime;
    }

    // Update is called once per frame
    public void Update()
    {
        if (currentTime <= 1)
        {

            stahp = false;
            currentTime = 0.0f;
            slider.value = 1;

        }
        if (stahp) {
            value += Time.deltaTime/startTime;
            slider.value = value;
            //val += (float) Time.deltaTime;
        currentTime -= Time.deltaTime;
            currentTimeHours = currentTime / 60;
        currentTimeSeconds = (currentTime%60)-1;
           //currentTimeSeconds -= Time.fixedDeltaTime;
        timeText.text = currentTimeHours.ToString("00") + ":" + currentTimeSeconds.ToString("00");
    }
       
    }
}
