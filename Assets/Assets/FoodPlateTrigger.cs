using UnityEngine;

public class FoodPlateTrigger : MonoBehaviour
{
    public LabGameManager gameManager;
    public SampleType sampleType;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Assiette touchée par : " + other.name);

        PipetteTool pipette = other.GetComponentInParent<PipetteTool>();

        if (pipette == null)
        {
            Debug.LogWarning("Aucun PipetteTool trouvé sur " + other.name);
            return;
        }

        if (pipette.hasSample)
        {
            Debug.Log("La pipette a déjà un échantillon.");
            return;
        }

        pipette.SetSample(true, sampleType);

        if (gameManager != null)
            gameManager.OnSampleTaken(sampleType);
        else
            Debug.LogWarning("GameManager non assigné.");
    }
}