using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SwitchLight : MonoBehaviour
{
    public GameObject light;
    public GameObject shadow;
    private Light l;
    private NavMeshObstacle s;
    // Start is called before the first frame update
    void Start()
    {
        l = light.GetComponent<Light>();
        s = shadow.GetComponent<NavMeshObstacle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player" && Input.GetKey("e"))
        {
            switchLight();
        }
    }

    public void switchLight()
    {
        l.enabled = !l.enabled;
        s.enabled = !s.enabled;
    }
}
