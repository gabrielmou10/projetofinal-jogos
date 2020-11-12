using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed1;

    // Update is called once per frame
    void Update()
    {       
        transform.position += Vector3.left * speed1 * Time.deltaTime;
    }
}
