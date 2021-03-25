using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class broMove : MonoBehaviour
{
    public Transform goal;
    public float speed, offsetx, offsetz;
    public string SceneName;
    private NavMeshAgent agent;
    private Rigidbody rb;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        agent.updatePosition = false;
        agent.updateRotation = false;
        
        animator = gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        this.agent.SetDestination(new Vector3(goal.position.x + offsetx, goal.position.y, goal.position.z + offsetz));
        rb.velocity = agent.velocity;
        speed = rb.velocity.magnitude;
        if (speed > 0) rb.MoveRotation(Quaternion.LookRotation(rb.velocity));

        agent.nextPosition = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Goal")
        {
            GameManager.Instance.loadScene(SceneName);
        }
    }
}
