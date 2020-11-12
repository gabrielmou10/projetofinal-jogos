using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public AudioClip AudioScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score = Score.score+1;
        AudioSource.PlayClipAtPoint(AudioScore, transform.position);

    }

}
