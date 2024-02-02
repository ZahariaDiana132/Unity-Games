using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator an;
    private SpriteRenderer sprite;
    [SerializeField]  float runningSpeed = 7f;
    [SerializeField] float jumpVelocity = 7f;

    [SerializeField] private LayerMask jmpGrnd;
    private BoxCollider2D bcll;

    private enum movement {idle,running,jumping,falling}

    [SerializeField] private AudioSource jump; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        bcll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dX = Input.GetAxisRaw("Horizontal");
        AnimationUpdate(dX);
        rb.velocity = new Vector2(dX*runningSpeed,rb.velocity.y);
        if(Input.GetButtonDown("Jump") && OnGround()) //unity input system in project settings
        {
            jump.Play();
            rb.velocity = new Vector2(rb.velocity.x,jumpVelocity);

        }
    }
    private void AnimationUpdate(float dX){
        movement state;
    if(dX > 0f)
        {
           state=movement.running;
           sprite.flipX = false;
        }
        else if(dX < 0f)
        {
         sprite.flipX = true;
         state=movement.running;
        }
        else
         state=movement.idle;

        if(rb.velocity.y > .1f)
        {
          state=movement.jumping;  

        }
        else if (rb.velocity.y < -.1f)
        {
            state=movement.falling;  
        }
         an.SetInteger("state",(int)state);
}

private bool OnGround()
{ return Physics2D.BoxCast(bcll.bounds.center,bcll.bounds.size,0f,Vector2.down,.1f,jmpGrnd); //check if grounded by checking if the boxcast overlaps with ground
}
}

