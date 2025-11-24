using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickup : MonoBehaviour
{
    public CapsuleCollider collider = new CapsuleCollider(); // sphere collide
    public float shieldDuration = 3f; // seconds
    public Color shieldColor = Color.blue; // tint color
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
    }
    public void OnTriggerEnter(Collider other)
    {
        // Check if player touched it
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Shield picked up!");

            // Start shield effect
            StartCoroutine(ActivateShield(other.gameObject));

            // Destroy shield object
            Destroy(gameObject);
        }
    }

    private IEnumerator ActivateShield(GameObject player)
    {
        // Get player renderer


        // Wait for duration
        Debug.Log("Start");
        yield return new WaitForSeconds(shieldDuration);
        Debug.Log("End");
        // Reset color

    }
}
