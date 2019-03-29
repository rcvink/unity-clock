using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 10f;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {
        // Set some local float variables equal to the value of our Horizontal and Vertical Inputs
        float moveHorizontal = Input.GetAxis("Horizontal_P2");
        float moveVertical = Input.GetAxis("Vertical_P2");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 movement = new Vector3(moveHorizontal, 50.0f, moveVertical);
            // Add a physical force to our Player rigidbody using our 'movement' Vector3 above,
            // multiplying it by 'speed' - our public player speed that appears in the inspector
            rb.AddForce(movement * speed);
        }
        else
        {

            // Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            // Add a physical force to our Player rigidbody using our 'movement' Vector3 above,
            // multiplying it by 'speed' - our public player speed that appears in the inspector
            rb.AddForce(movement * speed);
        }

    }
}
