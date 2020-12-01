/*
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WindowHandler : MonoBehaviour
{
    public WindowType windowType;

    public WindowData windowData;

    public void Start()
    {
        if (string.IsNullOrEmpty(windowData.id))
        {
            windowData.id = System.DateTime.Now.ToLongDateString() + System.DateTime.Now.ToLongTimeString() + Random.Range(0, int.MaxValue).ToString();
            windowData.windowType = windowType;
            SaveData.current.uiWindows.Add(windowData);
        }

        GameEvents.current.OnLoadEvent += DestroyMe;
    }

    void DestroyMe()
    {
        GameEvents.current.OnLoadEvent -= DestroyMe;
        Destroy(gameObject);
    }

    private void Update()
    {
        windowData.position = transform.position;
    }


}
*/