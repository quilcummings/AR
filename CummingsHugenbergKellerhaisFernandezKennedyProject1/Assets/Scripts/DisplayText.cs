using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject target;
    

    void Update()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist < 0.1)
        {
            text.text = "Moorish Idol";
        }
        else
        {
            text.text = "";
        }
    }
    
}
