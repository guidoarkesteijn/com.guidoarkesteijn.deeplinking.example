using UnityEngine;
using Guido.Arkesteijn.DeepLink.Runtime;
using System.Collections.Generic;

public class DeepLinkTester
{
    [DeepLink(uri = "company")]
    public static void OnCompanyReceived(int identifier)
    {
        SimpleViewController.LoadCompany(identifier);
    }

    [DeepLink(uri = "product")]
    public static void OnProductReceived(int identifier)
    {
        SimpleViewController.LoadProduct(identifier);
    }
}
