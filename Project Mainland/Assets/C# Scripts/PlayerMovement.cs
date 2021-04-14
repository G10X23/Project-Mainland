using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    Vector2 move;
    private enum State{idle, running}
    private State state = State.idle;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
        
        
    }
}
