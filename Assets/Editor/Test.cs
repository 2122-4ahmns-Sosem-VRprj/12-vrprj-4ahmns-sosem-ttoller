using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PGButton))]
public class Test : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        PGButton button = (PGButton)target;

        if (GUILayout.Button("Press"))
        {
            button.OnButtonPressed();
        }
    }
}
