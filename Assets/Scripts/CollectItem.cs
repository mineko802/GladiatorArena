using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CollectItem : MonoBehaviour
{
    [Header("Input Actions")]
    public InputAction collectAction; // Assign in Inspector or via code

    [SerializeField] private Collider currentCollectible;
    private List<int> ItemsID = new List<int>();

    private void OnEnable()
    {
        // Enable the action and subscribe to performed event
        collectAction.Enable();
        collectAction.performed += OnCollectPerformed;
    }

    private void OnDisable()
    {
        // Unsubscribe to avoid memory leaks
        collectAction.performed -= OnCollectPerformed;
        collectAction.Disable();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Store reference if it's a collectible
        if (other.CompareTag("Item"))
        {
            currentCollectible = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Clear reference when leaving collectible area
        if (other == currentCollectible)
        {
            currentCollectible = null;
        }
    }

    private void OnCollectPerformed(InputAction.CallbackContext context)
    {
        if (currentCollectible != null)
        {
            // Example: Destroy collectible and add score
            Debug.Log("Collected: " + currentCollectible.name);
            Destroy(currentCollectible.gameObject);
            currentCollectible = null;
        }
    }
}
