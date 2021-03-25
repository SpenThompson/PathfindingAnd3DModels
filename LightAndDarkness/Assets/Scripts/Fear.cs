using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fear : MonoBehaviour
{
    public int currentFear= 0;
    public int maxFear = 100;
    private bool inDark;

    public FearGauge fearGauge;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Shadow"))
        {
            if (!inDark) inDark = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Shadow"))
        {
            if (inDark) inDark = false;
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        currentFear = maxFear;
        inDark = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inDark) DamagePlayer(1);
    }

    public void DamagePlayer(int damage)
    {
        currentFear -= damage;
        fearGauge.SetFear(currentFear);
    }
}
