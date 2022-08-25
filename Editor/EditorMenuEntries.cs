using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class EditorMenuEntries : MonoBehaviour
{
    [MenuItem("Rob/Simple Entry")]
    public static void SimpleMenuEntry()
    {
        Debug.Log("Simple Menu entry");
    }
}