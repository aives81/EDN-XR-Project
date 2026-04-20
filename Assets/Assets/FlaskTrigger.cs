using UnityEngine;

public class FlaskTrigger : MonoBehaviour
{
    public LabGameManager gameManager;
    public FlaskContainer flaskContainer;

    private void OnTriggerEnter(Collider other)
    {
        PipetteTool pipette = other.GetComponent<PipetteTool>();

        if (pipette != null && pipette.hasSample && !flaskContainer.hasSample)
        {
            pipette.SetSample(false);
            flaskContainer.hasSample = true;
            gameManager.OnSampleTransferredToFlask();
        }
    }
}