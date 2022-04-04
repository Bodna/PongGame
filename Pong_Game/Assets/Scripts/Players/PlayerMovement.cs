using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Vector3 pos = new Vector3();

    private void Update() {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 22, 27), 0 , Mathf.Clamp(transform.position.z, -29, -24));
    }
}
