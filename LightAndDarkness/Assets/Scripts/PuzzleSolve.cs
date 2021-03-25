using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PuzzleSolve : MonoBehaviour
{
    public GameObject[] lightFixtures;
    private NavMeshAgent b;
    private Light[] lights;
    // Start is called before the first frame update
    void Start()
    {
        for(int n = 0; n < lightFixtures.Length; n++)
        {
            lights[n] = lightFixtures[n].GetComponentsInChildren<Light>()[0];
        }
        b = GetComponent<NavMeshAgent>();
    }

    private bool lightsOn()
    {
        for(int i = 0; i < lights.Length; i++)
        {
            if (lights[i].enabled == false)
            {
                return false;
            }
        }
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        switch (lightsOn())
        {
            case true:
                b.enabled = true;
                break;
            case false:
                b.enabled = false;
                break;
        }
    }
}
