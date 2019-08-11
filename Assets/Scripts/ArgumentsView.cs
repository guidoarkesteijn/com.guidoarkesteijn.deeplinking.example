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

        argumentsFullText += DeepLink.Instance.ArgumentString + "\n";

        if (DeepLink.Instance.Payload != null)
        {
            foreach (var item in DeepLink.Instance.Payload)
            {
                argumentsFullText += $"{item.Key}: {item.Value}\n";
            }
        }

        argumentsText.text = argumentsFullText;
    }
}
