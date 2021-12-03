using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerLevel : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setLevel(int level)
    {
        PlayerPrefs.SetInt("Level", level);
        SceneManager.LoadScene(3);
    }
}
