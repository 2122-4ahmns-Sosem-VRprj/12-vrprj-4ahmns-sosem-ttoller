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
            LeanTween.value(1, 0, 2).setOnUpdate((float val) =>
            {
                hasShown = true;
                img.color = new Color(0, 0, 0, val);
            });
        }
    }
}
