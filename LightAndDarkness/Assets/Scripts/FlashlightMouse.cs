using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMouse : MonoBehaviour
{
    private Vector3 pos;
    private float vertical;
    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        pos.x += vertical;
        pos.z += horizontal;
    }
    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Mouse Y");
        horizontal = Input.GetAxis("Mouse X");
        pos = transform.position;
    }
}
