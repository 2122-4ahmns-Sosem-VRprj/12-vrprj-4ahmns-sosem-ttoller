using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject doorIn;
    public AudioClip doorClose;
    public AudioClip doorFall;
    private bool closed = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Controller" && !closed)
        {
            print("Hit " + other.gameObject.name);
            CloseDoor();
        }
    }

    private void CloseDoor()
    {
        closed = true;
        AudioSource doorAudio = doorIn.GetComponent<AudioSource>();
        doorAudio.PlayOneShot(doorFall);
        LeanTween.rotateY(doorIn, 90, doorFall.length - 0.5f).setEaseInCirc().setOnComplete(() =>
        {
            doorAudio.PlayOneShot(doorClose);
        });
    }
}
