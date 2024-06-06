using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject gokyuzu1;
    public GameObject gokyuzu2;
    public float arkaPlanHiz = -1.5f;

    Rigidbody2D fizik1;
    Rigidbody2D fizik2;

    float uzunluk = 0;
    void Start()
    {
        fizik1 = gokyuzu1.GetComponent<Rigidbody2D>();
        fizik2 = gokyuzu2.GetComponent<Rigidbody2D>();

        fizik1.velocity = new Vector2 (-1.5f, 0.0f);
        fizik2.velocity = new Vector2(-1.5f, 0.0f);

        uzunluk = gokyuzu1.GetComponent<BoxCollider2D>().size.x;


    }

    
    void Update()
    {
        if (gokyuzu1.transform.position.x<= -uzunluk)
        {
            gokyuzu1.transform.position += new Vector3(uzunluk * 2, 0);
        }
        if (gokyuzu2.transform.position.x <= -uzunluk)
        {
            gokyuzu2.transform.position += new Vector3(uzunluk * 2, 0);
        }
    }
}
