using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackBehaviorUI : MonoBehaviour
{
    [SerializeField] protected Button backButton;

    protected void Awake()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void OnBackButtonClicked()
    {
        SimpleViewController.UnloadTopView();
    }
}
