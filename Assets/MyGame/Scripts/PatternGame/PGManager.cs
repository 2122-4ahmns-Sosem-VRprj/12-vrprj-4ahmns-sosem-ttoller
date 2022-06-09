using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGManager : MonoBehaviour
{
    public AudioClip successSound;
    public AudioClip finishSound;
    public AudioClip failSound;
    public AudioClip displaySound;
    public PGDisplay[] displays;
    public PGButton[] buttons;
    public Material[] materials;
    public int[] correctPattern;
    public int currentIndex;
    public int nextCorrect;

    private void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            Material mat = materials[i];

            PGDisplay display = displays[i];
            display.id = i;
            display.gameObject.GetComponent<Renderer>().material = mat;
            display.material = mat;

            PGButton button = buttons[i];
            display.button = button;
            button.id = i;
            button.gameObject.GetComponent<Renderer>().material = mat;
        }
        ResetDisplays();
    }
    private void GiveHint()
    {
        displays[nextCorrect].SetPending();
    }
    public void PressedButton(int id)
    {
        //check if the button was already pressed
        if (displays[id].state == PGDisplay.DisplayStates.ON) return;
        if (correctPattern[currentIndex] == id)
        {
            int lastId = correctPattern[currentIndex];
            currentIndex++;
            if (currentIndex == correctPattern.Length)
            {
                displays[lastId].SetOn();
                GameMaster.FinishGame();
            }
            else
            {
                nextCorrect = correctPattern[currentIndex];
                GameMaster.PlayClipAtCamera(successSound);
                Debug.Log("Correct input: now at " + currentIndex + "/" + correctPattern.Length + ", next correct input is " + nextCorrect);
                displays[lastId].SetOn();
                GiveHint();
            }
        }
        //don't reset, too hard otherwise
        // else
        // {
        //     Debug.Log("Wrong input: expected " + correctPattern[currentIndex] + ", got " + id);
        //     PlayClipAtCamera(failSound);
        //     ResetDisplays();
        //     GiveHint();
        // }
    }
    private void ResetDisplays()
    {
        correctPattern = GenerateList();
        currentIndex = 0;
        nextCorrect = correctPattern[0];
        foreach (PGDisplay display in displays)
        {
            display.SetOff();
        }
        GiveHint();
    }
    private int[] GenerateList()
    {
        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        System.Random random = new System.Random();
        array = array.OrderBy(x => random.Next()).ToArray();
        Debug.Log("Pattern: " + String.Join(", ", array));
        return array;
    }
    public GameObject GetNextButton()
    {
        return buttons[nextCorrect].gameObject;
    }
}