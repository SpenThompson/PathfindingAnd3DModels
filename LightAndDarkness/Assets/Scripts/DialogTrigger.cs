using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
       if(collider.CompareTag("Player"))
        {
            GameManager.Instance.StartDialog(text);
        }
    }

    void OnTriggerExit(Collider collider)
    {
       if(collider.CompareTag("Player"))
        {
            GameManager.Instance.HideDialog();
        }
    }
}
