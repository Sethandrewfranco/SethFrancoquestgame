using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * -speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Quest"))
        {
            other.gameObject.SetActive(false);

            winText.text = "You have hit the back wall, jumped the ramp, hit the stop wall, and landed on the lower level";
        }
        if (other.gameObject.CompareTag("Object"))
        {
            other.gameObject.SetActive(false);

        }
    }
}
