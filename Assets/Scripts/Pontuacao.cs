using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pontuacao : MonoBehaviour {

    public Text txtP;
    public static int Pont;
    // Use this for initialization
    void Start()
    {
        Pont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txtP.text = Pont.ToString();

    }
}
