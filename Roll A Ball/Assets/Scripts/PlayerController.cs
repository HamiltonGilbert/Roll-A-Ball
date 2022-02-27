using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    //public float jumpHeight = 0;
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

    //void OnJump(InputValue movementValue)
    //{
        //Vector3 movement = new Vector3(0, 1, 0);
        //rb.AddForce(movement * jumpHeight);
    //}

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }

    //void FixedUpdate()
    //{
    //    Vector3 movement = new Vector3(moveX, 0.0f, moveY);
    //    rb.AddForce(movement * speed);
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup") && ! winTextObject.activeSelf)
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
}
