using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float steerSpeed = 300f;
    float slowSpeed = 8f;
    float boostSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        inputHandle();
       
    }

    private void inputHandle()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, -steerAmount);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;  
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Booster") 
        {
            Debug.Log("Yo Hoo!!");
            moveSpeed = boostSpeed;
            Destroy(other.gameObject);
        }
    }

}
