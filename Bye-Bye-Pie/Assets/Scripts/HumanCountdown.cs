using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanCountdown : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            StartCoroutine(PieCountdownRoutine());

        }


    }

        IEnumerator PieCountdownRoutine()
        {
            yield return new WaitForSeconds(7);
         
            Destroy(gameObject);
            
            
        }

}
