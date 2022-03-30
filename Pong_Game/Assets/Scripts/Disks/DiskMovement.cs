using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float minSpeed;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }
    private void Update() {
<<<<<<< Updated upstream
        Debug.Log(rb.velocity);
=======
        //Debugging velocity
        Debug.Log(Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z));
        //Appplying force if elocity too low
       
        ApplyRandomForce();
        transform.position = new Vector3(transform.position.x, high, transform.position.z);
    }

    public void ApplyRandomForce(){
        if((Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y) + Mathf.Abs(rb.velocity.z)) < minSpeed)
            rb.AddForce(new Vector3(Random.Range(5, 15), 0, Random.Range(5, 15)), ForceMode.Impulse);
>>>>>>> Stashed changes
    }
}
