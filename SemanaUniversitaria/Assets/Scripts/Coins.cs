using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int moeda = 0;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("coin")) {
            moeda++;
            Destroy(other.gameObject);
            print(moeda);
        }
    }
    
}
