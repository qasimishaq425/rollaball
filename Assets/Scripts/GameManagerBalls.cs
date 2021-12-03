using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerBalls : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setprefrence(int value)
    {
        PlayerPrefs.SetInt("Value", value);

        SceneManager.LoadScene(2);
        
    }
}
