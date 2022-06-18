using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackoutController : MonoBehaviour
{
    public Image img;
    private int frames;
    public bool hasFadeIn;
    public bool hasFadeOut = false;
    public AudioClip deathWhisper;
    public AudioClip womanScream;
    private void Update()
    {
        if (!hasFadeIn)
        {
            FadeIn();
        }
    }
    public void FadeOut(bool death)
    {
        if (!hasFadeOut)
        {
            hasFadeOut = true;
            if (death)
            {
                GameMaster.PlayClipAtCamera(deathWhisper);
                LeanTween.value(0, 1, 4)
                .setOnStart(() =>
                {
                    GameMaster.PlayClipAtCamera(womanScream);
                })
                .setOnUpdate((float val) =>
                {
                    img.color = new Color(0, 0, 0, val);
                })
                .setDelay(4)
                .setOnComplete(() =>
                {
                    Application.Quit();
                    UnityEditor.EditorApplication.isPlaying = false;
                });
            }
            else
            {

                LeanTween.value(0, 1, 2)
                .setOnUpdate((float val) =>
                {
                    img.color = new Color(0, 0, 0, val);
                }).setOnComplete(() =>
                {
                    Application.Quit();
                    UnityEditor.EditorApplication.isPlaying = false;
                });
            }
        }
    }
    public void FadeIn()
    {
        hasFadeIn = true;
        LeanTween.value(1, 0, 2).setOnUpdate((float val) =>
        {
            img.color = new Color(0, 0, 0, val);
        });
    }
}
