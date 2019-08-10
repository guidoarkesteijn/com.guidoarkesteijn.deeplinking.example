﻿using UnityEngine;
using Guido.Arkesteijn.DeepLink.Runtime;
using System.Collections.Generic;

public class DeepLinkTester : MonoBehaviour
{
    [DeepLink(uri = "Company")]
    public void OnCompanyReceived(Dictionary<string,object> payload)
    {
        SimpleViewController.LoadCompany(payload);
    }

    [DeepLink(uri = "Product")]
    public void OnProductReceived(Dictionary<string, object> payload)
    {
        SimpleViewController.LoadProduct(payload);
    }

    [DeepLink(uri = "Message")]
    public void OnMessageReceived(Dictionary<string, object> payload)
    {

    }
}
