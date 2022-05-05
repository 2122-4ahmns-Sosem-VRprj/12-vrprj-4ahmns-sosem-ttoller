using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGButton : MonoBehaviour
{
    public int id;
    public AudioClip pressedSound;
    private PGManager manager;
    private AudioSource audioSource;

    private void Start()
    {
        manager = GameObject.FindObjectOfType<PGManager>().GetComponent<PGManager>();
    }
    //Button pressed
    public void OnButtonPressed()
    {
        if (pressedSound != null)
        {
            // gameObject.GetComponent<AudioSource>().PlayOneShot(pressedSound);
        }
        manager.PressedButton(id);
    }
}
