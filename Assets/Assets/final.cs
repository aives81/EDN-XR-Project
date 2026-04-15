using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class final : MonoBehaviour
{
    public TextMeshProUGUI scanText;
    public bool portiontaken;
    public bool isResultDisplayed = false;

    public void ShowResult()
    {
        if(portiontaken) {
            scanText.text =
            "Molécule détectée : Capsaïcine\n\n" +
            "Saveur : Épicé\n\n" +
            "Quel ingrédient a saboté la recette ?\n\n" +
            "Piment  |  Citron  |  Sucre  |  Café";
            isResultDisplayed = true;
        }
    }
}
