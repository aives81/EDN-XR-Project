using UnityEngine;

public class ScannerTrigger : MonoBehaviour
{
    public LabGameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        FlaskContainer flask = other.GetComponentInParent<FlaskContainer>();

        if (flask == null) return;
        if (!flask.hasSample) return;

        if (gameManager != null)
            gameManager.OnFlaskScanned();
    }
}