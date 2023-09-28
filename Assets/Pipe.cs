using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {
    void Awake() {
        Destroy(gameObject, 25);
    }

    void Update() {
        if (PlayerController.started) {
            transform.position += (Vector3) (Vector2.left * 4.5f * Time.deltaTime); // * Delta time removes frame-rate dependence
        }
    }
}
