using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 20f;

  
    
    [SerializeField]
    private Rigidbody2D myBody;

    [SerializeField]
    private BoxCollider2D myCollider2D;

    [SerializeField]
    private SpriteRenderer sr;

    private Animator anim;

    private string WALK_ANIMATION = "Walk";

    private float movementX;
    private void Awake()
    {
        myBody=GetComponent<Rigidbody2D>();
        myCollider2D=GetComponent<BoxCollider2D>();
        sr= GetComponent<SpriteRenderer>(); 
        anim= GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        PlayerAnimation();
      
    }
    private void FixedUpdate()
    {
        PlayerJump();
    }
    private void PlayerMovement()
    {
        movementX = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(movementX, 0f,0f) * moveForce * Time.deltaTime;
    }

    private void PlayerAnimation()
    {
        if(movementX > 0f)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if(movementX < 0f) 
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }

    private void PlayerJump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            myBody.AddForce (new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    
}
