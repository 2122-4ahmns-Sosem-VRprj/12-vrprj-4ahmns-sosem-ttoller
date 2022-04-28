using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGButton : MonoBehaviour
{
    public int id;
    public AudioClip pressedSound;
    private PGManager manager;

    private void Start() {
        // manager = FindObjectOType<PGManager>();
    }
    //Button pressed
    public void OnButtonPressed() {
        if (pressedSound != null) {
            AudioSource.PlayClipAtPoint(pressedSound, transform.position);
        }
        manager.pressedButton(id);
    }
}
