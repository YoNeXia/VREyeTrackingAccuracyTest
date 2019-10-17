﻿//
// Copyright: Aalborg University
// Author: YoNeXia <yohann.neraud@viacesi.fr> (https://gitlab.com/YoNeXia)
// Git: https://github.com/med-material/VREyeTrackingAccuracyTest
//
// Date: 10/7/2019
//
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class AdaptField : MonoBehaviour
{

    // Set variables
    private InputField inputField;
    private Text text;

    [SerializeField]
    private Text errorField;

    // Use this for initialization
    void Start()
    {
        // Get components
        inputField = GetComponent<InputField>();
        text = GetComponentInChildren<Text>();
    }

    // When mouse enter in the Input Field
    public void MouseInInputField()
    {
        // Set text in iput Field
        text.text = "Edit";
    }

    // When mouse exit the Input Field
    public void MouseOutInputField()
    {
        switch (inputField.name)
        {
            case "email":
                text.text = "example@example.com";
                break;
            case "user":
                text.text = "Participant 1";
                break;
            case "test":
                text.text = "Test 1";
                break;
            case "comment":
                text.text = "No comment";
                break;
            default:
                text.text = "";
                break;
        }
    }

    public void CompleteField()
    {
        if (inputField.text != "")
        {
            switch (inputField.name)
            {
                case "user":
                    inputField.text = "Participant " + inputField.text;
                    break;
                case "test":
                    inputField.text = "Test " + inputField.text;
                    break;
                default:
                    break;
            }
        }
    }

    public void EmailIsValid()
    {
        if (!Regex.IsMatch(inputField.text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
        {
            inputField.textComponent.color = new Color(1f, 0f, 0f, 1f);
            errorField.GetComponent<ErrorField>().ChangeTextValue(4);
            return;
        }
        inputField.textComponent.color = new Color(0.196f, 0.196f, 0.196f, 1f);
        errorField.GetComponent<ErrorField>().ChangeTextValue(0);
        return;
    }
}