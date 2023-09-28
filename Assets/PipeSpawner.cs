using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {
    public GameObject pipes;
    public float secondsPerPipe = 1;
    private float timer;
    
    void Update() {
        if (PlayerController.started) {
            if (timer <= 0) {
                timer = secondsPerPipe;
                Instantiate(pipes, (Vector2) transform.position + Vector2.up * Random.Range(2, -2), Quaternion.identity);
            }
            else {
                timer -= Time.deltaTime;
            }
        }
    }
}
