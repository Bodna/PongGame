using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Vector2 rangeX, rangeZ;

    
    private async void Update() {
        transform.localPosition += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, rangeX.x, rangeX.y), 0 , Mathf.Clamp(transform.position.z, rangeZ.x, rangeZ.y));
    }
}
