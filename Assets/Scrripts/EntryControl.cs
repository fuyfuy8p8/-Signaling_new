using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryControl : MonoBehaviour
{
    [SerializeField] AlarmManager _alarmManager;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonMovement>())
        {
            _alarmManager.StartChangeSound(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<FirstPersonMovement>())
        {
            _alarmManager.StartChangeSound(false);
        }
    }
}
