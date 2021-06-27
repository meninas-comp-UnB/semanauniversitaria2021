using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimentation : MonoBehaviour
{

    public float velH;
    public float velV;

    void Start()
    {

    }


    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3 (H*velH*Time.deltaTime,0,0));
    }
}
