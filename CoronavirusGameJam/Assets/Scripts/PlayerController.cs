using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;

    private Rigidbody rb;
    private SphereCollider interactCollider;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        interactCollider = GetComponent<SphereCollider>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        float hv = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(hv * playerSpeed, rb.velocity.y, rb.velocity.z) * Time.deltaTime;
    }

    void Interact()
    {
        interactCollider.enabled = false;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Stair") && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }
}
