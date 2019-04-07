using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    // Start is called before the first frame update


	public static int cur_premium_amount = 15;
    public static int cur_custom_amount = 100;

    public Text txt_premium;
    public Text txt_custom;
    void Start () {

		// txt_premium = GetComponent<Text>();
        // txt_custom = GetComponent<Text>();
		

	}
    void Update () {

		txt_premium.text = cur_premium_amount.ToString();
        txt_custom.text = cur_custom_amount.ToString();

	}

    public static void DeductPremium(int deduction){

		cur_premium_amount -= deduction;


	}


    public static void DeductCustom(int deduction){

		cur_custom_amount -= deduction;


	}

        public static void AddPremium(int add){

		cur_premium_amount += add;


	}


    public static void AddCustom(int add){

		cur_custom_amount += add;


	}

}
