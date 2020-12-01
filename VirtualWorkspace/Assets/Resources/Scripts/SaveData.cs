using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
    public class SaveData
{
    private static SaveData _current;
    public static SaveData current
    {
        get
        {
            if(_current == null)
            {
                _current = new SaveData();
            }
            return _current;
        }
    }

    public PlayerProfile profile;
    public int toyCars;
    public int toyDolls;
    public List<WindowData> uiWindows;
   
}