using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_actions : MonoBehaviour
{
    public void GravityChange()
    {
        GameObject kocka = GameObject.Find("Kocka");
        if (kocka.GetComponent<Rigidbody>().useGravity == true)
        {
            kocka.GetComponent<Rigidbody>().useGravity = false;
        }
        else
        {
            kocka.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
