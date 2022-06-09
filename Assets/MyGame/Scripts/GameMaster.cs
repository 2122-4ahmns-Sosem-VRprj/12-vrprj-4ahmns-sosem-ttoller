using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public AudioClip introSound;
    public AudioClip outroSound;
    public AudioClip music;
    private static GameObject doorOut;
    private AudioSource musicSource;
    public static void FinishGame()
    {
        LeanTween.rotateY(doorOut, -95, 1.0f);
    }
    private void Start()
    {
        doorOut = GameObject.Find("DoorOut");
        musicSource = Camera.main.GetComponent<AudioSource>();
        musicSource.clip = music;
        Debug.Log(musicSource);
        musicSource.Play();
        LeanTween.value(0, 1, introSound.length).setOnUpdate((float val) =>
        {
            musicSource.volume = val;
            print(musicSource.volume);
        });
        PlayClipAtCamera(introSound);
    }
    public static void PlayClipAtCamera(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    }
}
