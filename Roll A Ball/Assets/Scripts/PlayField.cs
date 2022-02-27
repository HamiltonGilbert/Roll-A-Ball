using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayField : MonoBehaviour
{
    public int speed = 0;
    //public int jumpHeight = 0;

    private float rotateX;
    private float rotateZ;
    //private float jump;
    //private bool jumpBool = true;
    //private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 moveVector = movementValue.Get<Vector2>();
        //print(moveVector);
        rotateX = moveVector.x * -1;
        rotateZ = moveVector.y;
    }

    /*void OnJump(InputValue movementValue)
    {
        //if (counter >= 100)
        //{
        jump = jumpHeight;
        //}
    }*/

    /*void gravity()
    {
        if (transform.position.y < 0)
        {
            transform.SetPositionAndRotation()
        }
    }*/

    void FixedUpdate()
    {
        Vector3 rotation = new Vector3(rotateZ, 0.0f, rotateX);
        transform.Rotate(rotation * speed * .1f);
        /*transform.Translate(0, jump, 0);
        if (transform.position.y > 0)
            jump -= jumpHeight / 10;
        if (transform.position.y < 0)
        {
            jump = 0;
            transform.
        }
        //rb.AddForce(new Vector3(0, jump, 0));
        jump = 0;
        //gravity();*/
    }
}
