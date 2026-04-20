using UnityEngine;

public class ScannerTrigger : MonoBehaviour
{
    public LabGameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        FlaskContainer flask = other.GetComponent<FlaskContainer>();

        if (flask != null && flask.hasSample)
        {
            gameManager.OnFlaskScanned();
        }
    }
}