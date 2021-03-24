using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SwitchLight : MonoBehaviour
{
    public GameObject[] lightFixtures;
    private Light[] l;
    private NavMeshObstacle[] s;
    private bool keyPressed;
    // Start is called before the first frame update
    void Start()
    {
        for (int n = 0; n < lightFixtures.Length; n++) 
        {
            l[n] = lightFixtures[n].GetComponentsInChildren<Light>()[0];
            s[n] = lightFixtures[n].GetComponentsInChildren<NavMeshObstacle>()[0];
        }
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
        for(int i = 0; i < lightFixtures.Length; i++)
        {
            l[i].enabled = !l[i].enabled;
            s[i].enabled = !s[i].enabled;
        }
    }
}
