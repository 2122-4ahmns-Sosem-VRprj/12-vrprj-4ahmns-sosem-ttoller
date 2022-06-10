using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public AudioClip introSound;
    public static AudioClip _outroSound;
    public AudioClip outroSound;
    public AudioClip music;
    private static GameObject exitTrigger;
    private static AudioSource musicSource;
    public AudioClip heartbeat;

    public static void FinishGame()
    {
        PlayClipAtCamera(_outroSound);
        exitTrigger.GetComponent<DoorTrigger>().locked = false;
    }
    private void Start()
    {
        exitTrigger = GameObject.Find("ExitTrigger");
        _outroSound = outroSound;
        musicSource = Camera.main.GetComponent<AudioSource>();
        musicSource.clip = music;
        Debug.Log(musicSource);
        musicSource.Play();
        LeanTween.value(0, 1, introSound.length).setOnUpdate((float val) =>
        {
            musicSource.volume = val;
        });
        PlayClipAtCamera(introSound);

    }

    public static void PlayClipAtCamera(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    }
}
