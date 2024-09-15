using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideController : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> opcionesSprite;
    public GestorAsteroides gestor;
    // Start is called before the first frame update
    void Start()
    {
        gestor.asteroides_actuales = gestor.asteroides_actuales + 1;

        sr = GetComponent<SpriteRenderer>();
        int escogido = Random.Range(0, opcionesSprite.Count);
        sr.sprite = opcionesSprite[escogido];
    }

    public void Muerte()
    {
        if (transform.localScale.x > 0.25f) //Alternativa 0.6
        {
            GameObject asteroide1 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
            asteroide1.GetComponent<AsteroideController>().gestor = gestor;
            asteroide1.transform.localScale = transform.localScale * 0.5f; //Alternativa 0.75

            GameObject asteroide2 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
            asteroide2.GetComponent<AsteroideController>().gestor = gestor;
            asteroide2.transform.localScale = transform.localScale * 0.5f; //Alternativa 0.75
        }
        gestor.asteroides_actuales = gestor.asteroides_actuales - 1;
        GameManager.instance.puntuacion = GameManager.instance.puntuacion + 100;
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<CharacterMover>().Muerte();
        }
    }
}
