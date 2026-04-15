using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class portion : MonoBehaviour
{
    public TextMeshProUGUI scanText;
    public bool portiontaken = false;
    public bool isScanned = false;

    public void ShowResult()
    {
        scanText.text =
        "Prend l'echantillon et place le dans le fiole.";
        portiontaken = true;
    }
}
