using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayField : MonoBehaviour
{
    public int speed = 0;

    private float rotateX;
    private float rotateY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 moveVector = movementValue.Get<Vector2>();
        rotateX = moveVector.x * -1;
        rotateY = moveVector.y;
    }

    void FixedUpdate()
    {
        Vector3 rotation = new Vector3(rotateY, 0.0f, rotateX);
        transform.Rotate(rotation * speed * .1f);
    }
}
