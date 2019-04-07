using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject button;
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (!timer.activeSelf)
        {
            button.SetActive(true);
        }
    }
}
