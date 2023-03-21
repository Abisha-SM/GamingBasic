using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float Speed,horizontalmultiplayer,jumpforce;
    private float HorizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        Vector3 forwardmove = transform.forward * Speed * Time.fixedDeltaTime;
        Vector3 horizontalmove = transform.right * HorizontalInput * Time.fixedDeltaTime*horizontalmultiplayer;
        rigidbody.MovePosition(rigidbody.position + forwardmove+horizontalmove);
    }
    void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        rigidbody.AddForce(Vector3.up * jumpforce);
    }
}
