using UnityEngine;

public class PlateTrigger : MonoBehaviour
{
    public LabGameManager gameManager;

    public PipetteTool pipette;

    private void OnTriggerEnter(Collider other)
    {

        if (other.name.Equals("Glass_medical_dropper"))
        {
            pipette.hasSample = true;


            if (gameManager != null)
                gameManager.OnSampleTaken();
            else
                Debug.LogWarning("GameManager not assigned in PlateTrigger");
        }
        else
        {
            Debug.Log("No PipetteTool found on: " + other.name);
        }
    }
}