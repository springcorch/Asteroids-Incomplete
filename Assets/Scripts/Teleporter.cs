using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public float vertical = 6;
    public float horizontal = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1.1 Teletransporte
        if (transform.position.y > vertical)
        {
            transform.position = new Vector3(transform.position.x, -vertical, transform.position.z);
        }

        if (transform.position.y < -vertical)
        {
            transform.position = new Vector3(transform.position.x, vertical, transform.position.z);
        }
        if (transform.position.x > horizontal)
        {
            transform.position = new Vector3(-horizontal, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -horizontal)
        {
            transform.position = new Vector3(horizontal, transform.position.y, transform.position.z);
        }

    }
}
