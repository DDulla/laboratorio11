using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocidad;
    public int direccionX;
    public int direccionY;
    private Rigidbody2D Movimiento;
    private SpriteRenderer Rotacion;
    private void Awake()
    {
        Movimiento = GetComponent<Rigidbody2D>();
        Rotacion = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Movimiento.velocity = new Vector2(velocidad * direccionX, velocidad * direccionY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "limite")
        {
            direccionX = direccionX * -1;
            Rotacion.flipX = true;
        }
        if (collision.gameObject.tag == "limite")
        {
            direccionY = direccionY * -1;
            Rotacion.flipY = true;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
