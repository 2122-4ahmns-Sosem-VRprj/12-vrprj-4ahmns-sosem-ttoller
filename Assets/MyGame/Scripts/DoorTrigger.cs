using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;
    public AudioClip doorClose;
    public AudioClip doorFall;
    private bool closed = false;
    public bool reversed = false;
    public bool locked = false;
    public BlackoutController blackout;
    private AudioSource musicSource;
    private void Start()
    {
        if (reversed)
        {
            closed = true;
            locked = true;
        }
        musicSource = Camera.main.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Controller" && !locked)
        {
            if (!reversed && !closed) CloseDoor();
            else if (reversed && closed) OpenDoor();
        }
    }

    private void OpenDoor()
    {
        closed = false;
        AudioSource doorAudio = door.GetComponent<AudioSource>();
        doorAudio.PlayOneShot(doorClose);
        LeanTween.rotateY(door, -117, doorFall.length).setEaseInCirc().setOnComplete(() =>
        {
            blackout.FadeOut();
        }).setDelay(doorClose.length - 0.5f).setOnStart(() =>
        {
            doorAudio.PlayOneShot(doorFall);
        });

        LeanTween.value(1, 0, 2).setOnUpdate((float val) =>
        {
            musicSource.volume = val;
        });
    }

    private void CloseDoor()
    {
        closed = true;
        AudioSource doorAudio = door.GetComponent<AudioSource>();
        doorAudio.PlayOneShot(doorFall);
        LeanTween.rotateY(door, 90, doorFall.length - 0.5f).setEaseInCirc().setOnComplete(() =>
        {
            doorAudio.PlayOneShot(doorClose);
        });
    }
}
