using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class coinbhr : MonoBehaviour
{
    public SphereCollider collider = new SphereCollider(); // sphere collide
    public CoinCounter cm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collider = GetComponent<SphereCollider>();
    }
    public void OnTriggerEnter(Collider other)
    {
        //remove Self
        if (other.gameObject.CompareTag("Coin"))
        {
            //add score
            Debug.Log("Coin touched");
            Destroy(other.gameObject);
            cm.coinAmount++;
        }
    }

    // Update is called once per frame
}
