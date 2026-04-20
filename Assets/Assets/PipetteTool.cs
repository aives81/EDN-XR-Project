using UnityEngine;

public class PipetteTool : MonoBehaviour
{
    public bool hasSample = false;
    public GameObject sampleVisual;

    public void SetSample(bool value)
    {
        hasSample = value;

        if (sampleVisual != null)
            sampleVisual.SetActive(value);
    }
}