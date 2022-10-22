using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClownfishDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject target;
    
    void Update()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist < 0.1)
        {
            text.text = "Clownfish";
        }
        else
        {
            text.text = "";
        }
    }
}
