using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalMove = 0f;
    [Header("Speed")]
    [Range(0, 15f)] public float speed = 1f;
    private bool facingRight = true;
    [Header("Player Settings")]
    [Range(0,15f)]public float jumpForce = 8f;
    [Header("Ground Settings")]
    public bool isGrounded = false;
    [Range(-2f, 2f)] public float checkGroundOffsetY = -1.1f;
    [Range(-2f, 2f)] public float checkGroundRadius = 0.3f;
    public Animator animator;
    public Animator Campfire;
    [Header("Audio")]
    [SerializeField] private AudioSource stepAudio;
    public AudioSource jumpAudio;
    public AudioSource FireAudio;
    //float SX, SY;
    new Vector3 respawn;
    public GameObject checkPoint;
    [SerializeField] private float damge;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Campfire.enabled = false;
        //SX = transform.position.x;
        //SY = transform.position.y;
        respawn = transform.position;
        //checkPoint.SetActive(false);
        checkPoint.SetActive(false);
    }
    

    

    
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        animator.SetFloat("horizontal", Mathf.Abs(horizontalMove));
        if(Input.GetButtonDown("Horizontal"))
        {
            stepAudio.Play();
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            stepAudio.Stop();
        }
        if (horizontalMove < 0 && facingRight)
        {
            Flip();
        }
        else if (horizontalMove > 0 && !facingRight)
        {
            Flip();
        }
        if(isGrounded && Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            stepAudio.Stop();
            jumpAudio.Play();
        }
        if(isGrounded == false)
        {
            animator.SetBool("jump", true);
            
        }
        else
        {
            animator.SetBool("jump", false);
        }
    }

    private void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(horizontalMove * 2f, rb.velocity.y);
        rb.velocity = targetVelocity;
        CheckGround();
    }

    private void Flip()
    {
        facingRight = !facingRight;
        //Vector3 theScale = transform.localScale;
        //theScale.x *= -1;
        //transform.localScale=theScale;
        transform.Rotate(0f, 180f, 0f);
    }

    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y + checkGroundOffsetY), checkGroundRadius);
        if(colliders.Length > 1)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Dead&ReturnZone")
        {
            //transform.position = new Vector3(SX, SY, transform.position.z);
            transform.position = respawn;
        }
        else if(collision.gameObject.tag == "CheckPoint")
        {
            FireAudio.Play();
            checkPoint.SetActive(true);
            respawn = transform.position;
            //Campfire.enabled = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        checkPoint.SetActive(false);
        //FireAudio.enabled = false;
    }
}
