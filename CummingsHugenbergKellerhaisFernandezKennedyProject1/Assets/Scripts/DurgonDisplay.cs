using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DurgonDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject target;
    
    void Update()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist < 0.3)
        {
            text.text = "Durgon Trigger";
        }
        else
        {
            text.text = "";
        }
    }
}
