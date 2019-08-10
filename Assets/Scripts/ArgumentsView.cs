using Guido.Arkesteijn.DeepLink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArgumentsView : MonoBehaviour
{
    [SerializeField] protected TMPro.TextMeshProUGUI argumentsText;

    protected void Awake()
    {
        string argumentsFullText = "";

        if (DeepLink.Arguments != null)
        {
            foreach (var item in DeepLink.Arguments)
            {
                argumentsFullText += $"{item}\n";
            }
        }

        argumentsText.text = argumentsFullText;
    }
}
