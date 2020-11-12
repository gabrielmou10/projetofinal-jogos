using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        if (Level.level == 0){
            score = 0;
        }
        if (Level.level == 1){
            score = 10;
        }
        if (Level.level == 2){
            score = 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

    }
}
