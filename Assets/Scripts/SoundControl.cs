using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundControl : MonoBehaviour
{
    public AudioSource audiosource;
    private bool flag = true;
    public Slider mySlider;
    public Text volumetext;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playSound()
    {
        if(flag==false)
        {

            audiosource.Stop();
           // audiosource.volume = mySlider.value;
                
           flag = true;
        }
        else
        {
            audiosource.Play();
         
            flag = false;
        }
    }
    public void slidervolume()
    {
        volumetext.text = ((int)(mySlider.value*100)).ToString();
        audiosource.volume = mySlider.value;

    }
}
