using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGManager : MonoBehaviour
{
    public AudioClip successSound;
    public AudioClip failSound;
    public AudioClip displaySound;
    public PGDisplay[] displays;
    public PGButton[] buttons;
    private int[] correctPattern;
    private int currentIndex;

    private void Start()
    {
        correctPattern = generateList();
        currentIndex = 0;
    }
    private void giveHint()
    {
        int nextId = correctPattern[currentIndex];
        displays[currentIndex].setPending();

        AudioSource.PlayClipAtPoint(displaySound, transform.position);
    }
    public void pressedButton(int id)
    {
        if (correctPattern[currentIndex] == id)
        {
            currentIndex++;
            if (currentIndex == correctPattern.Length)
            {
                AudioSource.PlayClipAtPoint(successSound, Camera.main.transform.position);
                winGame();
            }
        }
        else
        {
            AudioSource.PlayClipAtPoint(failSound, Camera.main.transform.position);
            resetDisplays();
            correctPattern = generateList();
            currentIndex = 0;
            giveHint();
        }
    }
    private void winGame()
    {
        Debug.Log("You win!");
    }
    private void resetDisplays()
    {
        foreach (PGDisplay display in displays)
        {
            display.setOff();
        }
    }
    private int[] generateList()
    {
        int[] list = new int[displays.Length];
        for (int i = 0; i < correctPattern.Length; i++)
        {
            list[i] = Random.Range(0, buttons.Length);
        }
        return list;
    }
}
