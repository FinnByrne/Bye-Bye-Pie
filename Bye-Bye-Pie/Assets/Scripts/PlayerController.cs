using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRB;
    public bool hasPie;
    public GameObject pieIndicator;


    public string translationAxisName = "Z";

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //switch (translationAxisName)
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //pieIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pie"))
        {
            hasPie = true;
            Destroy(other.gameObject);

            pieIndicator.gameObject.SetActive(true);
        }
        else if (other.CompareTag("Human") && hasPie)
        {

            pieIndicator.gameObject.SetActive(false);

            Destroy(other.gameObject);
        }
    }

    IEnumerator PieCountdownRoutine()
    {
        yield return new WaitForSeconds(999);
        hasPie = false;
        pieIndicator.gameObject.SetActive(false);
    }
}

// 0.005, 1.2, -4.56
// 24.9, 0, 0