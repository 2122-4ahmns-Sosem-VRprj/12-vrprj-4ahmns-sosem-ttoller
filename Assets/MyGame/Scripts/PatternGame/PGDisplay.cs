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
    public float emissionRate = 0.5f;
    public int signalOffset = 10;
    public PGButton button;
    public void SetOff()
    {
        state = DisplayStates.OFF;
        Color color = material.GetColor("_Color");
        material.SetColor("_EmissionColor", color * minEmission);
        LeanTween.cancelAll();
        StopAllCoroutines();
    }
    public void SetPending()
    {
        Debug.Log("Display " + id + " is pending");
        state = DisplayStates.PENDING;
        LeanTween.value(gameObject, minEmission, maxEmission, emissionRate).setOnUpdate((float value) =>
        {
            Color color = material.GetColor("_Color");
            material.SetColor("_EmissionColor", color * value);
        }).setLoopPingPong();
        StartCoroutine(SendAudioSignal());
    }
    IEnumerator SendAudioSignal()
    {
        yield return new WaitForSeconds(signalOffset);
        button.PlaySound();
        StartCoroutine(SendAudioSignal());
    }
    public void SetOn()
    {
        Debug.Log("Display " + id + " is on");
        state = DisplayStates.ON;
        Color color = material.GetColor("_Color");
        material.SetColor("_EmissionColor", color * maxEmission);
        LeanTween.cancelAll();
        StopAllCoroutines();
    }
}
