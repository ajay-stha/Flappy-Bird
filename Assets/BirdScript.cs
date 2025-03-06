using System;
using System.Linq;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float JumpForce = 5;
    private bool IsBirdAlive = true;
    public LogicScript Logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindGameObjectsWithTag("Logic").First().GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space)) && IsBirdAlive)
        {
            MyRigidBody.linearVelocity = Vector2.up * JumpForce;
        }

        if (Math.Abs(transform.position.y) > 17)
        {
            Logic.GameOver();
            IsBirdAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.GameOver();
        IsBirdAlive = false;
    }
}
