using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb2;
    [SerializeField] private float power_ball = 4;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(new Vector2(0.5f,1.2f) * Time.deltaTime * power_ball );        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        Block block = c.gameObject.GetComponent<Block>();
        if (block != null)
        {
            int score_block = block.KickBlock();
            if (score_block >= 0)
            {
                Debug.Log("Score added " + score_block);
                GameManager.instance.AddScore(score_block);
            }
            else
            {
                Debug.Log("kick");
            }
        }
    }
}
