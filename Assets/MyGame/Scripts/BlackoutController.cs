using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackoutController : MonoBehaviour
{
    public Image img;
    private int frames;
    private bool hasFadeIn;
    private bool hasFadeOut = false;
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
                LeanTween.value(0, 1, 2).setOnUpdate((float val) =>
                            {
                                img.color = new Color(0, 0, 0, val);
                            }).setDelay(4);
            }
            else
            {

                LeanTween.value(0, 1, 2).setOnUpdate((float val) =>
                {
                    img.color = new Color(0, 0, 0, val);
                }).setOnComplete(() =>
                {
                    Application.Quit();
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
