using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour {
    // Update is called once per frame
    public float speed = 3.0f;
    public float obstacleRange = 1f;

    private bool _alive;

    private void Start() {
        _alive = true;
    }


    void Update() {
        if (_alive) {
            Ray ray = new Ray(transform.position, transform.forward);

            RaycastHit hit;

            if (Physics.SphereCast(ray, 0.75f, out hit)) {
                if (hit.distance < obstacleRange) {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                    return;
                }
            }

            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }

    public void SetAlive(bool alive) {
        _alive = alive;
    }
}