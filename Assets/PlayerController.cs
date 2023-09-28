using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float jumpPower;
    
    public static bool started;
    public ParticleSystem death;
    private Rigidbody2D rigidbody;
    
    void Awake() {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.gravityScale = 0;
    }

    void Update() {
        if (Input.anyKeyDown) {
            Jump();
            started = true;
        }
        
        if (started) {
            rigidbody.gravityScale = 2;
        }
        else {
            rigidbody.gravityScale = 0;
        }
    }

    public void Jump() {
        rigidbody.velocity = Vector2.up * jumpPower;
    }

    public void OnCollisionEnter2D(Collision2D other) {
        death.Play();
        StartCoroutine(Restart());
        started = false;
        GetComponent<Renderer>().enabled = false;
    }

    IEnumerator Restart() {
        yield return new WaitForSeconds(0.7f);
        print("die");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
