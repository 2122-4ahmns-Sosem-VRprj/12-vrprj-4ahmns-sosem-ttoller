using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;

    private void Start()
    {
        time = 0;
    }
    private void Update()
    {
        time += Time.deltaTime;
        TimeSpan t = TimeSpan.FromSeconds(time);
        GetComponent<Text>().text = t.ToString(@"mm\:ss");
    }
}
