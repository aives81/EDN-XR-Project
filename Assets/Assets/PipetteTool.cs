using UnityEngine;

public class PipetteTool : MonoBehaviour
{
    public bool hasSample = false;
    public SampleType currentSample = SampleType.None;
    public GameObject sampleVisual;

    public void SetSample(bool value, SampleType type)
    {
        hasSample = value;
        currentSample = value ? type : SampleType.None;

        if (sampleVisual != null)
            sampleVisual.SetActive(value);
    }
}