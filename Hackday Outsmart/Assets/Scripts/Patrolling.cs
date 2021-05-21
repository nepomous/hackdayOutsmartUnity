using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public float movementSpeed = 3.0f;
    public float distance;
    private bool isGoingRight = false;
    public Transform groundDetection;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        if(groundInfo.collider == false) {
            if(isGoingRight == false) {
                transform.eulerAngles = new Vector3(0, -180, 0);
                isGoingRight = true;
            } else {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isGoingRight = false;
            }
        }
    }
}
