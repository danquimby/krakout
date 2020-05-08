using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2;
    [SerializeField] private float speed = 20;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
    }
    void Update()
    {
        float inputY = Input.GetAxis ("Vertical");
        rb2.velocity = new Vector2(rb2.velocity.x,speed * inputY);
    }
}
