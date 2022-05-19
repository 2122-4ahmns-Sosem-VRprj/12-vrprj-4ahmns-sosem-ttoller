using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGButton : MonoBehaviour
{
    public int id;
    public AudioClip signalSound;
    private PGManager manager;
    private AudioSource audioSource;

    private void Start()
    {
        manager = GameObject.FindObjectOfType<PGManager>();
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = signalSound;
    }
    //Button pressed
    public void OnButtonPressed()
    {
        manager.PressedButton(id);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Controller") OnButtonPressed();
    }
    public void PlaySound()
    {
        print("Play sound at " + transform.position);
        audioSource.Play();
    }
}
