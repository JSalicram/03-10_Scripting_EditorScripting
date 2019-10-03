using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SelectAllOfTag : ScriptableWizard
{
    public string searchTag = "your tag here...";

    [MenuItem ("My Tools/Select all of tag...")]
    static void SelectAllOfWizard()
    {
        ScriptableWizard.DisplayWizard<SelectAllOfTag>("Select All Of Tag...", "Make Selection");
    }

    private void OnWizardCreate()
    {
        GameObject[] gameobjects = GameObject.FindGameObjectsWithTag(searchTag);
        Selection.objects = gameobjects;
    }
}
