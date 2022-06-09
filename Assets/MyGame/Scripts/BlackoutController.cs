using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackoutController : MonoBehaviour
{
    public Image img;
    private int frames;
    private bool hasShown;
    private void Update()
    {
        if (!hasShown)
        {
            FadeIn();
        }
    }
    public void FadeOut()
    {
        LeanTween.value(0, 1, 2).setOnUpdate((float val) =>
        {
            img.color = new Color(0, 0, 0, val);
        }).setOnComplete(() =>
        {
            Application.Quit();
        });
    }
    public void FadeIn()
    {
        hasShown = true;
        LeanTween.value(1, 0, 2).setOnUpdate((float val) =>
        {
            img.color = new Color(0, 0, 0, val);
        });
    }
}
