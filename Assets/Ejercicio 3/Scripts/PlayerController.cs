using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    float speed = 5000f;
    public int moneda;

    private float direction;

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() 
    {
        rigidBody2D.velocity = Vector2.zero;
        rigidBody2D.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, 0);
    
        if(moneda < 0)
        {
            moneda = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D Coll)
    {

        if (Coll.gameObject.tag == "Obstaculo" && moneda > 0)
        {
            moneda = moneda - 2;
        }
        if (Coll.gameObject.tag == "moneda")
        {
            moneda = moneda + 1;

        }
    }
}
