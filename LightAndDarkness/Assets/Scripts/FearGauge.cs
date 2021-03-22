using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearGauge : MonoBehaviour
{
    public Slider fearGauge;
    public Fear playerFear;

    // Start is called before the first frame update
    void Start()
    {
        playerFear = GameObject.FindGameObjectWithTag("Player").GetComponent<Fear>();
        fearGauge = GetComponent<Slider>();
        fearGauge.maxValue = playerFear.maxFear;
        fearGauge.value = playerFear.maxFear;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFear(int fp)
    {
        fearGauge.value = fp;
    }
}
