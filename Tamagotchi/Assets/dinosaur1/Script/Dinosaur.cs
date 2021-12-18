using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    Rigidbody2D rb;
    bool isJumping;

    public GameManager gameManager;
    AudioSource jumpsound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        jumpsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isJumping == false)
        {
            rb.velocity = new Vector3(0, 20, 0);
            isJumping = true;
            jumpsound.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "obstacles"){
            gameManager.GameOver();
        }
    }

}
