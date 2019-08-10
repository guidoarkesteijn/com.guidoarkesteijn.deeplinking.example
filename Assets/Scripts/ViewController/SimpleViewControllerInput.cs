using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleViewControllerInput : MonoBehaviour
{
    protected void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            //Load Main
            SimpleViewController.LoadMain();
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            //Load Company
            SimpleViewController.LoadCompany();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            //Load Product
            SimpleViewController.LoadProduct();
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            //Load Message
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SimpleViewController.LoadCompany(MockData.COMPANY_1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SimpleViewController.LoadCompany(MockData.COMPANY_2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SimpleViewController.LoadCompany(MockData.COMPANY_3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SimpleViewController.LoadCompany(MockData.COMPANY_4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SimpleViewController.LoadCompany(MockData.COMPANY_5);
        }
        else if (Input.GetKeyDown(KeyCode.F1))
        {
            SimpleViewController.LoadProduct(MockData.PRODUCT_1);
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            SimpleViewController.LoadProduct(MockData.PRODUCT_2);
        }
        else if (Input.GetKeyDown(KeyCode.F3))
        {
            SimpleViewController.LoadProduct(MockData.PRODUCT_3);
        }
        else if (Input.GetKeyDown(KeyCode.F4))
        {
            SimpleViewController.LoadProduct(MockData.PRODUCT_4);
        }
        else if (Input.GetKeyDown(KeyCode.F5))
        {
            SimpleViewController.LoadProduct(MockData.PRODUCT_5);
        }
    }
}
