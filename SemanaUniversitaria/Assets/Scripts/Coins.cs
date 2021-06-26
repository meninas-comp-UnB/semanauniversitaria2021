using UnityEngine;

public class Coins : MonoBehaviour
{

    public int coins = 0;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            coins++;
            Destroy(other.gameObject);
            print (coins);
        }

    }
}
