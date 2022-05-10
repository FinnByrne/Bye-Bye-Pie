using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "the monkeee")
        {
            print("You Picked Up The Pie");
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
