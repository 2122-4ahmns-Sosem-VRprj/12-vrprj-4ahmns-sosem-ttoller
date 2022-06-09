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
    private static GameObject doorOut;
    private static AudioSource musicSource;
    public static void FinishGame()
    {
        LeanTween.rotateY(doorOut, -95, 1.0f);
        PlayClipAtCamera(_outroSound);
        LeanTween.value(1, 0, 2).setOnUpdate((float val) =>
        {
            musicSource.volume = val;
        });

    }
    private void Start()
    {
        doorOut = GameObject.Find("DoorOut");
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
