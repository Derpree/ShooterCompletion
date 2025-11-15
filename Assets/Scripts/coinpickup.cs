using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPick : MonoBehaviour
{
    public CoinCounter cm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            cm.coinAmount++;
        }
    }
}