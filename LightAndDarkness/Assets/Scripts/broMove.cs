using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class broMove : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        agent.updatePosition = false;
        agent.updateRotation = false;
        this.agent.SetDestination(goal.position);
    }

    private void FixedUpdate()
    {
        rb.velocity = agent.velocity;
        agent.nextPosition = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
