using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10;
    public string tagColision = "Destruible";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tagColision)
        {
            collision.GetComponent<AsteroideController>().Muerte();
            Destroy(gameObject);
        }
    }
}
