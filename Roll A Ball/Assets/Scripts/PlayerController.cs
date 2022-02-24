using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    //public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    //private Rigidbody rb;
    private int count;
    //private float moveX;
    //private float moveY;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnMove(InputValue movementValue)
    //{
    //    Vector2 moveVector = movementValue.Get<Vector2>();
    //    moveX = moveVector.x;
    //    moveY = moveVector.y;
    //}

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winTextObject.SetActive(true);
        }
    }

    //void FixedUpdate()
    //{
    //    Vector3 movement = new Vector3(moveX, 0.0f, moveY);
    //    rb.AddForce(movement * speed);
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
}
