using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmManager : MonoBehaviour
{
    [SerializeField] private AudioSource _alarmAudio;
    [SerializeField] private float _speed;

    private float _startVolume = 0f;
    private float _endVolume = 1f;
    private Coroutine _coroutine;
   
    public IEnumerator ChangeSound(float targetVolume)
    {
        _alarmAudio.Play();

        while (_alarmAudio.volume != targetVolume)
        {
            _alarmAudio.volume = Mathf.MoveTowards(_alarmAudio.volume, targetVolume, _speed * Time.deltaTime);

            yield return null;
        }

    }

    public void StartChangeSound(bool  isEntry)
    {
        if (_coroutine!= null)
        {
            StopCoroutine(_coroutine);
        }

        if (isEntry)
        {
           _coroutine= StartCoroutine(ChangeSound(_endVolume));
        }
        else
        {
           _coroutine = StartCoroutine(ChangeSound(_startVolume));
        }
    }
}
