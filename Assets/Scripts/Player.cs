using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour {
    public float velo, impul, posicao, move;

    private bool noChao, pular;

    public Transform sensor;


    private Animator anim;
    private Rigidbody2D rb2d;
    private bool alive;



	// Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        posicao = transform.localScale.x;
        alive = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (alive == true)
        {

            //moving
            move = Input.GetAxisRaw("Horizontal") * velo;

            //rose
            if (Input.GetAxisRaw("Horizontal") >0) {
                transform.localScale = new Vector2(posicao, transform.localScale.y);
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                transform.localScale = new Vector2(-posicao, transform.localScale.y);
            }

            //Grounded
            noChao = Physics2D.Linecast(transform.position, sensor.position, 1 << LayerMask.NameToLayer("Ground"));
            print(noChao);

            //jump
            if (Input.GetButtonDown("Jump") && noChao) {
                pular = true;
            }

        }
        if (Pontuacao.Pont >=5)
        {
            SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
        }
    }

    void FixedUpdate () {
        //Jump Cmd
        if (pular) {
            rb2d.AddForce(Vector2.up * impul);
            pular = false;
        }

        //animations trigger
        anim.SetFloat("Runing", Mathf.Abs(move));
        anim.SetBool("Jumping", noChao);
        anim.SetBool("Dead", alive);
        //move
        rb2d.velocity = new Vector2(move, rb2d.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.tag == "coin") {
            Destroy(coll.gameObject);
            Pontuacao.Pont++;

        } else if(coll.tag == "Ringin" && alive == true)
        {
            
            alive = false;
            anim.Play("Hurt",0,3f);
            rb2d.isKinematic = true;
            SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
        }


    }
}
