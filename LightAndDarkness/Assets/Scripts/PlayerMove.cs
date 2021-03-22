using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody body;
    Animator animator;

    float vertical;
    float horizontal;
    float moveSpeed = 5f;
    float moveLimiter = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("horizontal", horizontal);
        animator.SetFloat("vertical", vertical);
    }

    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector3(horizontal * moveSpeed, 0, vertical * moveSpeed);
    }
}
