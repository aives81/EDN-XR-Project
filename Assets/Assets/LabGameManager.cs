using TMPro;
using UnityEngine;

public class LabGameManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI scanText;

    [Header("Game State")]
    public bool sampleTaken = false;
    public bool sampleInFlask = false;
    public bool resultDisplayed = false;

    private void Start()
    {
        ShowMessage("Prenez la pipette et placez-la dans l'assiette pour prendre un échantillon.");
    }

    public void ShowMessage(string message)
    {
        if (scanText != null)
            scanText.text = message;
    }

    public void OnSampleTaken()
    {
        if (sampleTaken) return;

        sampleTaken = true;
        ShowMessage("Échantillon prélevé. Placez la pipette dans la fiole.");
    }

    public void OnSampleTransferredToFlask()
    {
        if (!sampleTaken || sampleInFlask) return;

        sampleInFlask = true;
        ShowMessage("Échantillon transféré dans la fiole. Placez la fiole dans le scanner.");
    }

    public void OnFlaskScanned()
    {
        if (!sampleInFlask || resultDisplayed) return;

        resultDisplayed = true;
        ShowMessage(
            "Molécule détectée : Capsaïcine\n\n" +
            "Saveur : Épicé\n\n" +
            "Quel ingrédient a saboté la recette ?\n\n" +
            "Piment | Citron | Sucre | Café"
        );
    }
}