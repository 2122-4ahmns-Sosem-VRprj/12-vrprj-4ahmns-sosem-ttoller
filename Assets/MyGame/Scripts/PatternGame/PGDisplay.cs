using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGDisplay : MonoBehaviour
{
    public int id;
    public enum DisplayStates { OFF, PENDING, ON };
    public DisplayStates state;
    public Material material;
    public void SetOff()
    {
        state = DisplayStates.OFF;
        Color color = material.GetColor("_Color");
        material.SetColor("_EmissionColor", color * 0);
    }
    public void SetPending()
    {
        Debug.Log("Display " + id + " is pending");
        state = DisplayStates.PENDING;
    }
    public void SetOn()
    {
        Debug.Log("Display " + id + " is on");
        state = DisplayStates.ON;
        Color color = material.GetColor("_Color");
        material.SetColor("_EmissionColor", color * 2f);
    }
}
