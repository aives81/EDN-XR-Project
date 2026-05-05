using UnityEngine;

public class FlaskTrigger : MonoBehaviour
{
    public LabGameManager gameManager;
    public FlaskContainer flaskContainer;

    private void OnTriggerEnter(Collider other)
    {
        PipetteTool pipette = other.GetComponentInParent<PipetteTool>();

        if (pipette == null) return;
        if (!pipette.hasSample) return;
        if (flaskContainer.hasSample) return;

        flaskContainer.hasSample = true;
        flaskContainer.currentSample = pipette.currentSample;

        pipette.SetSample(false, SampleType.None);

        if (gameManager != null)
            gameManager.OnSampleTransferredToFlask();
    }
}