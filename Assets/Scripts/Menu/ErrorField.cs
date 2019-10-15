﻿//
// Copyright: Aalborg University
// Author: YoNeXia <yohann.neraud@viacesi.fr> (https://gitlab.com/YoNeXia)
// Git: https://github.com/med-material/VREyeTrackingAccuracyTest
//
// Date: 10/7/2019
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorField : MonoBehaviour
{

    private Text missingField;

    // Use this for initialization
    void Start()
    {
        missingField = GetComponent<Text>();
    }

    public void ChangeTextValue(int field)
    {
        switch (field)
        {
            case 1:
                missingField.text = "Warning, mail field is empty!";
                break;
            case 2:
                missingField.text = "Warning, user ID field is empty!";
                break;
            case 3:
                missingField.text = "Warning, test number field is empty!";
                break;
            case 4:
                missingField.text = "Bad email entered...";
                break;
            case 5:
                missingField.text = "Please enter a Participant number";
                break;
            case 6:
                missingField.text = "Please enter a Test number";
                break;
            default:
                missingField.text = "";
                break;

        }

    }
}
