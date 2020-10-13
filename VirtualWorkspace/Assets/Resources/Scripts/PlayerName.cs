using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public TextMeshProUGUI playerText;

    // Start is called before the first frame update
    void Start()
    {
        playerText.text = DBManager.username;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
