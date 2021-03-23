using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    public GameObject light;
    private Light l;
    // Start is called before the first frame update
    void Start()
    {
        l = light.GetComponent<Light>();
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
    }
}
