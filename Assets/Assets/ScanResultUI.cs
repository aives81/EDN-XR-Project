using UnityEngine;
using TMPro;

public class ScanResultUI : MonoBehaviour
{
    public TextMeshProUGUI scanText;

    public void ShowResult()
    {
        scanText.text =
        "Molécule détectée : Capsaïcine\n\n" +
        "Saveur : Épicé\n\n" +
        "Quel ingrédient a saboté la recette ?\n\n" +
        "Piment  |  Citron  |  Sucre  |  Café";
    }
}