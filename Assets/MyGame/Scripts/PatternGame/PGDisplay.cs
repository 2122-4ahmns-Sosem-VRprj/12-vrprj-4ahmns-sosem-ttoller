using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGDisplay : MonoBehaviour
{
    public int id;
    public enum DisplayStates { OFF, PENDING, ON };
    public DisplayStates state;
    public Material material;
    public float maxEmission = 2f;
    public float minEmission = 0f;
    public void SetOff()
    {
        state = DisplayStates.OFF;
        Color color = material.GetColor("_Color");
        material.SetColor("_EmissionColor", color * minEmission);
        LeanTween.cancelAll();
    }
    public void SetPending()
    {
        Debug.Log("Display " + id + " is pending");
        state = DisplayStates.PENDING;
        LeanTween.value(gameObject, minEmission, maxEmission, 0.5f).setOnUpdate((float value) =>
        {
            Color color = material.GetColor("_Color");
            material.SetColor("_EmissionColor", color * value);
        }).setLoopPingPong();
    }
    public void SetOn()
    {
        Debug.Log("Display " + id + " is on");
        state = DisplayStates.ON;
        Color color = material.GetColor("_Color");
        material.SetColor("_EmissionColor", color * maxEmission);
        LeanTween.cancelAll();
    }
}
