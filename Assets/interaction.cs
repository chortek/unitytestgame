using UnityEngine;

public class interaction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check the tag of the other collider's GameObject
        if (other.CompareTag("coin"))
        {
            Debug.Log("Triggered by an object tagged 'Pickup'!");
            // Add your logic here (e.g., collect item)
            // Destroy(other.gameObject); // Example of destroying the other object
            other.gameObject.SetActive(false);
        }
    }
}

