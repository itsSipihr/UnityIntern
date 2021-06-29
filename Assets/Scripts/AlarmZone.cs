using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmZone : MonoBehaviour
{
    public AudioSource alarmSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "robotSphere")
        {
            alarmSound.Play();
            Debug.Log("Hitted robot");
        }
    }
}
