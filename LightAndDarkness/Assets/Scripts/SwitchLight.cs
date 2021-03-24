using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SwitchLight : MonoBehaviour
{
    public GameObject lightFixture;
    public GameObject otherLight;
    private Light l;
    private Light l1;
    private NavMeshObstacle s;
    private bool keyPressed;
    // Start is called before the first frame update
    void Start()
    {
        l = lightFixture.GetComponentsInChildren<Light>()[0];
        l1 = otherLight.GetComponentsInChildren<Light>()[0];
        s = lightFixture.GetComponentsInChildren<NavMeshObstacle>()[0];
        keyPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        keyPressed = Input.GetKeyDown("e");
    }

    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.name == "Player" && keyPressed)
        {
            switchLight();
        }
    }

    public void switchLight()
    {
        l.enabled = !l.enabled;
        l1.enabled = !l1.enabled;
        s.enabled = !s.enabled;
    }
}
