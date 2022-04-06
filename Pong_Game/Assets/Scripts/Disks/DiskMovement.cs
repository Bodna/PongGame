using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskMovement : MonoBehaviour
{


    [SerializeField] private float speed = 100;
    [SerializeField] private float minV = 30;

    private Rigidbody rb;
    private float high;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        high = transform.position.y;
    }
    private void Update() {
        //Debugging velocity
        //Debug.Log(Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z));
        //Appplying force if elocity too low
       
        ApplyRandomForce();
        transform.position = new Vector3(transform.position.x, high, transform.position.z);
    }

    public void ApplyRandomForce(){
        if((Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z)) < minV)
            rb.AddForce(new Vector3(Random.Range(5, 15), 0, Random.Range(5, 15)), ForceMode.Impulse);
    }
}
