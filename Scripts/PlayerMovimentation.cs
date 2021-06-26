using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimentation : MonoBehaviour
{
    public float speed = 2.5f;

    Rigidbody2D rigidBody2D;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
    float H = Input.GetAxis("Horizontal");
    float V = Input.GetAxis("Vertical");
    transform.Translate (new Vector3 (H*Time.deltaTime*speed, V*Time.deltaTime*speed, 0));
    }
}
