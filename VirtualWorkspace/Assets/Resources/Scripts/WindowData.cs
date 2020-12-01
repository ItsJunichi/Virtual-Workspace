using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public enum WindowType
{
    Basic
}

[System.Serializable]
public class WindowData
    {
    public string id;
    public WindowType windowType;
    public Vector3 position;
    public Quaternion rotation;
       
    }
