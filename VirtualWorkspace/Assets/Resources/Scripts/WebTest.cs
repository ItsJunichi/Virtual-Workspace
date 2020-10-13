using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;

public class WebTest : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW request = new WWW("http://localhost/sqlconnect/webtest.php");
        yield return request;
        Debug.Log(request.text);



        /*



        string[] webResults = request.text.Split('\t');


        foreach (string s in webResults)
        {
            Debug.Log(s);
        }


        or 


        Debug.Log(webResults[0]);
        int webNumber = int.Parse(webResults[1]);
        webNumber *=2;
        Debug.Log(webNumber);

        */
    }
}
