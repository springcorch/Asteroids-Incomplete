using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float fuerzaMax = 100f;
    public float fuerzaMin = 50f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // 1.1 Movimiento Asteroides
        float randomForce = Random.Range(fuerzaMin, fuerzaMax);
        Vector2 forceDirection = Random.insideUnitCircle.normalized * randomForce;
        rb.AddForce(forceDirection);

        // 1.2 Rotación Asteroides
        float randomRotation = Random.Range(0f, 360f);
        transform.eulerAngles = new Vector3(0, 0, randomRotation);
    }
}