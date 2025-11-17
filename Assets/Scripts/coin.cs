using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
    public float lifetime = 4f; //sec player has to collect
    void Start()
    {
        Destroy(gameObject, lifetime); //coin is destroyed based on lifetime
    }
 }
