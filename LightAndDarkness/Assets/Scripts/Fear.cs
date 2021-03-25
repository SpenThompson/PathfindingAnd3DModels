using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fear : MonoBehaviour
{
    public int currentFear;
    public int maxFear = 2700; // 2700 gives you 45 seconds in the dark at 60FPS
    private bool inDark;

    public FearGauge fearGauge;

    void OnTriggerStay(Collider collider)
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
        GameOverCheck();
        if (inDark) DamagePlayer(1);
    }

    void GameOverCheck()
    {
        if (currentFear <= 0) GameManager.Instance.GameOver();
    }

    public void DamagePlayer(int damage)
    {
        currentFear -= damage;
        fearGauge.SetFear(currentFear);
    }
}
