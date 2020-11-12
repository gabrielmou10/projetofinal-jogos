using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 1;
    private Rigidbody2D rb;
    public AudioClip AudioDie;
    public AudioClip AudioFly;
    
    
    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            AudioSource.PlayClipAtPoint(AudioFly, transform.position);
            rb.velocity = Vector2.up * speed;    
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(AudioDie, transform.position);
        gameManager.GameOver();
    }

}
