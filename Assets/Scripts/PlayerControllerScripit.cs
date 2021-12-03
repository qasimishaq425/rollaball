using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControllerScripit : MonoBehaviour
{
    public Joystick joystick;
    Renderer test;
    public float speed;
    public Text countText;
    private Rigidbody rb;
    private int count;
    public Text win;

    void Start()
    {
        test = GetComponent<MeshRenderer>();
        test.enabled=true;
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCount(); 
    }
    void FixedUpdate()
    {
        // float movehorizantal = Input.GetAxis("Horizontal");
        //float movevertical = Input.GetAxis("Vertical");
        float movehorizantal=joystick.Horizontal*1f;
        float movevertical = joystick.Vertical * 1f;
        Vector3 movement = new Vector3(movehorizantal, 0.0f, movevertical);
        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCount();
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Pick Up"))
        {
            //collider.gameObject.SetActive(false);
        }
    }
    void setCount()
    {
        countText.text = "Count :" + count.ToString();
        if(count>=10)
        {
            win.text = "You Win!";
        }
    }
}
