using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 10f;
    private int count = 0;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Hand"))
        {
            // Make the other game object (the pick up) inactive, to make it disappear
           // other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 1;

            // Run the 'SetCountText()' function (see below)
            // SetCountText();
            countText.text = count.ToString();
        }

    }

    void FixedUpdate()
    {
        // Set some local float variables equal to the value of our Horizontal and Vertical Inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
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
