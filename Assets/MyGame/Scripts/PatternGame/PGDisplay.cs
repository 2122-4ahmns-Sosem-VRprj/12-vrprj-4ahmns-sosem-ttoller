using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGDisplay : MonoBehaviour
{
    public int id;
    private enum DisplayStates { OFF, PENDING, ON };
    
    [SerializeField]
    private DisplayStates state;
    private void Start()
    {
        setOff();
    }
    public void setOff()
    {
        state = DisplayStates.OFF;
        Color color = GetComponent<Renderer>().material.GetColor("_EmissionColor");
        color = color / 2;
    }
    public void setPending()
    {
        state = DisplayStates.PENDING;
    }
    public void setOn()
    {
        state = DisplayStates.ON;
        Color color = GetComponent<Renderer>().material.GetColor("_EmissionColor");
        color = color * 2;
    }
}
