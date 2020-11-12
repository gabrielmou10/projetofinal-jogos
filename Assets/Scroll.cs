using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    
    public float scrollSpeed = 0.5f;
    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed,0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
