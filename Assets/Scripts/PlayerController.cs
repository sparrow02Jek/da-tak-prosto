using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    [SerializeField] private MeshAnimator meshAnimator;
    [SerializeField] private float speed;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshAnimator.Play("Idle");
    }
    
    void FixedUpdate()
    { 
        float velocity = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(velocity * speed * Time.fixedDeltaTime,rb.velocity.y, rb.velocity.z);
    }
}
