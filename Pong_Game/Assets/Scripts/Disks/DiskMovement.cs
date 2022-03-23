using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }
    private void Update() {
        Debug.Log(rb.velocity);
    }
}
