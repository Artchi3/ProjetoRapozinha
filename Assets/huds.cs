using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class huds : MonoBehaviour {


    public Text txtP;
    public static int Pont;
    // Use this for initialization
    void Start () {
        Pont = 0;
	}
	
	// Update is called once per frame
	void Update () {
        txtP.text = Pont.ToString();

    }
}
