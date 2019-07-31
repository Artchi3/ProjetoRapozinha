using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class botaozin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void yoogar1()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);


    }

    public void creditar2()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);


    }
    public void feixar()
    {
        Application.Quit();


    }
}
