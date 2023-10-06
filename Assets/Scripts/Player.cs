using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float movingForce = 10f;

    [SerializeField]
    private float jumpForce = 20f;

    [SerializeField]
    private Rigidbody2D myBody;

    [SerializeField]
    private BoxCollider2D myCollider2D;

    [SerializeField]
    private SpriteRenderer sr;

    private string WALK_ANIMATION = "Walk";


    private void Awake()
    {
        myBody=GetComponent<Rigidbody2D>();
        myCollider2D=GetComponent<BoxCollider2D>();
        sr= GetComponent<SpriteRenderer>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    private void playerMovement()
    {
       
    }
}
