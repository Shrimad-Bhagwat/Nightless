using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Story : MonoBehaviour
{
    public TextMeshProUGUI t; 
    void Start()
    {
        t.text = "";
    }

    public void SetText(string x){
        t.text = x;
    }

    
}
