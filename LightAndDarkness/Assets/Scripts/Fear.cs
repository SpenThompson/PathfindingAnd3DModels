using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fear : MonoBehaviour
{
    public int currentFear= 0;
    public int maxFear = 100;

    public FearGauge fearGauge;

    /*void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Shadow"))
        {
            DamagePlayer(1);
        }
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        currentFear = maxFear;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DamagePlayer(10);
        }



    }

    public void DamagePlayer(int damage)
    {
        currentFear -= damage;
        fearGauge.SetFear(currentFear);
    }
}
