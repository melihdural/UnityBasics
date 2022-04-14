using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour 
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField] //public Gameobject gmobj; tan�m� yerine kulland�k.
	Transform hoursPivot, minutesPivot, secondsPivot;

    private void Update()
    {
		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursPivot.localRotation   = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours /*Double'� Floata �evirmek i�in*/);
		minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
		secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
	}

}