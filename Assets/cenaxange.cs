using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class cenaxange : MonoBehaviour {

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        StartCoroutine(SeguraUmPouco());
        
    }

    IEnumerator SeguraUmPouco()
    {

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Iniciow", LoadSceneMode.Single);

    }

   
}
