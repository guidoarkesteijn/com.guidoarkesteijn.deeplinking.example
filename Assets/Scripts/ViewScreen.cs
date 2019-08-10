using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewScreen : MonoBehaviour, IView
{
    [SerializeField] private TMPro.TextMeshProUGUI payloadText;

    public void Setup(Dictionary<string, object> payload)
    {
        string payloadFullText = "";

        if (payload != null)
        {
            foreach (var item in payload)
            {
                payloadFullText += $"{item.Key}: {item.Value}\n";
            }
        }

        payloadText.text = payloadFullText;
    }
}
