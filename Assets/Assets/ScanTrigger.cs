using UnityEngine;

public class ScanTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered with: " + other.name);
    }
}