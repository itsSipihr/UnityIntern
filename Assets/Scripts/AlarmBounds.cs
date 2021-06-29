using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmBounds : MonoBehaviour
{
    public AudioSource alarmSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "robotSphere")
        {
            alarmSound.Stop();
            Debug.Log("Hitted sphere");
        }
    }
}
