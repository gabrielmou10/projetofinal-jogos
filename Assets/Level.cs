using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public static int level;

    
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Level: " + level.ToString();
    }
}
