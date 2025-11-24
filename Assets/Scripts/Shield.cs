using System.Collections;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float lifetime = 10f; // seconds before shield disappears if not picked up

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
