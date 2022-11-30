using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTopointMovement : MonoBehaviour
{
    public Vector3 pos1;
    public Vector3 pos2;
    public float speed;
    public string animState;
    public int pauseDuration;
    public bool yMovement;


    private bool dirRight= true;
    private bool pause = false;

    private SpriteRenderer mySprite;
    private Animator myAnimator;


    private void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        myAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (!pause)
        {
            if(!yMovement)
            {
                if (dirRight)
                {
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                }

                else if (!dirRight)
                {
                    transform.Translate(-Vector2.right * speed * Time.deltaTime);
                }
                if (transform.position.x - pos2.x >= float.Epsilon)
                {
                    pause = true;
                    dirRight = false;
                    mySprite.flipX = false;

                }

                if (transform.position.x - pos1.x <= -float.Epsilon)
                {
                    pause = true;
                    dirRight = true;
                    mySprite.flipX = true;

                }
            }
            else
            {
                if (dirRight)
                {
                    transform.Translate(Vector2.up * speed * Time.deltaTime);
                }

                else if (!dirRight)
                {
                    transform.Translate(-Vector2.up * speed * Time.deltaTime);
                }

                if (transform.position.y - pos2.y >= float.Epsilon)
                {
                    pause = true;
                    dirRight = false;
                    mySprite.flipX = false;

                }

                if (transform.position.y - pos1.y <= -float.Epsilon)
                {
                    pause = true;
                    dirRight = true;
                    mySprite.flipX = true;

                }
            }

        
           
           



        }
        else
        {
            //if (pauseDuration !=0 && animState != null)
            //{
            //    myAnimator.SetBool(animState, false);

            //}
            Invoke("Play", pauseDuration);
        }
        
        

    }


    private void Play()
    {
        //if(pauseDuration != 0 && animState!=null)
        //{
        //    myAnimator.SetBool(animState, true);

        //}

        pause = false;
    }
}
