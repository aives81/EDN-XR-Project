using UnityEngine;

public class ScanTrigger : MonoBehaviour
{
    public ScanResultUI resultUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sample"))
        {
            resultUI.ShowResult();
        }
    }
}