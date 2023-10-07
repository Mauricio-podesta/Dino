using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D PlayerRB;
    public float Jumpforce= 5;
    private bool Check;
    [SerializeField] GameOverScreen GameOver;
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Input.GetKeyDown(KeyCode.Space) && Check)
        {
            PlayerRB.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
            Check = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameOver.ActiveScreen();
        }
        Check = true;
    }

}
