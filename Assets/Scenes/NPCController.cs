using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 0.25f;
    private int count = 0;


    private float timeToChangeDirection = 1.5f;

    // Use this for initialization
    public void Start()
    {

        rb = GetComponent<Rigidbody>();
        //ChangeDirection();
    }

    // Update is called once per frame
    public void Update()
    {

        timeToChangeDirection -= Time.deltaTime;

        if (timeToChangeDirection <= 0)
        {
            // ChangeDirection();
            moveNPC();
        }

        //rb.velocity = transform.up * 2;

    }

    private void moveNPC()
    {

        float moveHorizontal = Random.Range(-180f, 180f);
        float moveVertical = Random.Range(-180f, 180f);
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // Add a physical force to our Player rigidbody using our 'movement' Vector3 above,
        // multiplying it by 'speed' - our public player speed that appears in the inspector
        rb.AddForce(movement * speed);
        timeToChangeDirection = 0.1f;
    }
    /*
    private void ChangeDirection()
    {
        float angle = Random.Range(0f, 360f);
        Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
        Vector3 newUp = quat;
        newUp.z = 0;
        newUp.Normalize();
        transform.up = newUp;
        timeToChangeDirection = 1.5f;
    }
    */
}
