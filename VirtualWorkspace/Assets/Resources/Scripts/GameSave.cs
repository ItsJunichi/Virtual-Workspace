﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSave : MonoBehaviour
{

    public GameObject window;

    // Start is called before the first frame update
    void Start()
    {
        RestoreGame();
    }

    void RestoreGame()
    {
        string p = PlayerPrefs.GetString("PlayerLocation");
        if (p != null && p.Length > 0)
        {
            SavePosition s = JsonUtility.FromJson<SavePosition>(p);
            if (s !=null)
            {
                Vector3 position = new Vector3();
                position.x = s.x;
                position.y = s.y;
                position.z = s.z;
                
                window.transform.position = position;

             
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SaveGame();
        }
    }

    void SaveGame()
    {
        SavePosition s = new SavePosition();
        s.x = window.transform.position.x;
        s.y = window.transform.position.y;
        s.z = window.transform.position.z;



        string json = JsonUtility.ToJson(s);
        Debug.Log(json);
        PlayerPrefs.SetString("PlayerLocation", json);
    }
}
