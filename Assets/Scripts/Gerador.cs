using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour {

    public float PeriodoI, periodoF, limiteX, limiteY;
    public GameObject coin;






	// Use this for initialization
	IEnumerator Start () {

        yield return new WaitForSeconds(Random.Range(PeriodoI, periodoF));


        Vector3 novaPosicao = new Vector3(Random.Range(-limiteX, limiteX), Random.Range(-limiteY, limiteY), 0.0f);
        Instantiate(coin, novaPosicao, transform.rotation);


        StartCoroutine(Start());
    }



}
