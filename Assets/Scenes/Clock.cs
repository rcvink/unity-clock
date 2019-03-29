using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float
        degreesPerHour = 30f,
        degreesPerMinute = 6f,
        degreesPerSecond = 6f,
        degreesContinous = 1f;

    public float seconds = 0f;
    public float minutes = 0;
    public float hours = 0;

    public long frame = 0;

    public Transform hoursTransform, minutesTransform, secondsTransform;

    void Awake()
    {
        clockMoveContinuous();
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    private void clockMove()
    {
        frame++;
       /* if (frame % 3600 == 0)
        {
            hours++;
        }
        if (frame % 60 == 0)
        {
            minutes;
        } */
       // if (frame % 1 == 0)
        //{
            seconds++;
            minutes = seconds / 12f;
            hours = minutes / 12f;
        //}

        secondsTransform.localRotation =
            Quaternion.Euler(0f, seconds * degreesContinous, 0f);
        minutesTransform.localRotation =
        Quaternion.Euler(0f, minutes * degreesContinous, 0f);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, hours * degreesContinous, 0f);
    }


    private void clockMoveContinuous()
    {
        frame++;
        if (frame % 3600 == 0)
        {
            hours++;
        }
        if (frame % 60 == 0)
        {
            minutes++;
        }
        if (frame % 1 == 0)
        {
            seconds++;
        }

        secondsTransform.localRotation =
            Quaternion.Euler(0f, seconds * degreesPerSecond, 0f);
        minutesTransform.localRotation =
        Quaternion.Euler(0f, minutes * degreesPerMinute, 0f);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, hours * degreesPerHour, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        clockMove();
    }
}
