using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextChange : MonoBehaviour
{
    public Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void valueChanged(Toggle t)
    {
        if (t.isOn)
        {
            t.GetComponentInChildren<Text>().text = "Toggle is on";
        }
        else
        {
            t.GetComponentInChildren<Text>().text = "Toggle is off";
        }
    }


}
