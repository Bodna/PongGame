using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField] private float bumpForce = 20;
    [SerializeField] private float radius = 20;
    //give force when bump into it
    private void OnCollisionEnter(Collision collision) {
        if(collision.transform.tag == "Player"){
            Rigidbody otherRB = collision.rigidbody;
            otherRB.AddExplosionForce(bumpForce, collision.contacts[0].point, radius);
        }
    }
}
