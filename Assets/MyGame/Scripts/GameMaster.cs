using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private static GameObject doorOut;
    public static void FinishGame()
    {
        LeanTween.rotateY(doorOut, -95, 1.0f);
    }
    private void Start()
    {
        doorOut = GameObject.Find("DoorOut");
    }
}
