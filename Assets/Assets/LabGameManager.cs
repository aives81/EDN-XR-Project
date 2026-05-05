using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SampleType
{
    None,
    Sushi,
    Algue
}

public class LabGameManager : MonoBehaviour
{
    [Header("Effects")]
    public ParticleSystem virusParticles;
    public TextMeshProUGUI scanText;

    public SampleType selectedSample = SampleType.None;
    public bool sampleTaken = false;
    public bool sampleInFlask = false;
    public bool resultDisplayed = false;

    private void Start()
    {
        ShowMessage("Choisissez un échantillon : sushi ou algue.\nPrenez la pipette et touchez une assiette.");
    }

    public void ShowMessage(string message)
    {
        if (scanText != null)
            scanText.text = message;
    }

    public void OnSampleTaken(SampleType type)
    {
        if (sampleTaken) return;

        selectedSample = type;
        sampleTaken = true;

        if (type == SampleType.Sushi)
            ShowMessage("Échantillon de sushi prélevé.\nPlacez la pipette dans la fiole.");

        if (type == SampleType.Algue)
            ShowMessage("Échantillon d'algue prélevé.\nPlacez la pipette dans la fiole.");
    }

    public void OnSampleTransferredToFlask()
    {
        if (!sampleTaken || sampleInFlask) return;

        sampleInFlask = true;
        ShowMessage("Échantillon transféré dans la fiole.\nPlacez la fiole dans le scanner.");
    }

    public void OnFlaskScanned()
    {
        if (!sampleInFlask || resultDisplayed) return;

        resultDisplayed = true;

        if (selectedSample == SampleType.Algue)
        {
            ShowMessage("Analyse terminée.\n\nRésultat : VIRUS DÉTECTÉ.\nL'échantillon d'algue est contaminé.");
            if (virusParticles != null)
            {
                virusParticles.gameObject.SetActive(true);
                virusParticles.Play();
            }
        }
        else if (selectedSample == SampleType.Sushi)
        {
            ShowMessage("Analyse terminée.\n\nRésultat : aucun virus détecté.\nEssayez un autre échantillon.");
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}