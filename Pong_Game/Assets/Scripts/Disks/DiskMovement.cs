using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskMovement : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField] private float speed;
=======
    [SerializeField] private float speed = 100;
    [SerializeField] private float minV = 30;
>>>>>>> Stashed changes
    private Rigidbody rb;
    private float high;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        high = transform.position.y;
    }
    private void Update() {
        //Debugging velocity
        Debug.Log(Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z));
        //Appplying force if elocity too low
       
        ApplyRandomForce();
        transform.position = new Vector3(transform.position.x, high, transform.position.z);
    }

    public void ApplyRandomForce(){
<<<<<<< Updated upstream
        if((Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z)) < 8)
=======
        if((Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z)) < minV)
>>>>>>> Stashed changes
            rb.AddForce(new Vector3(Random.Range(5, 15), 0, Random.Range(5, 15)), ForceMode.Impulse);
    }
}
