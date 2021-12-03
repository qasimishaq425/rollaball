using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    
    public Material[] mArray;
   // public MeshRenderer player;
   public GameObject [] playerArray;
   // public List<GameObject> playerlist;

    // Start is called before the first frame update
    void Start()
    {



        //int value = PlayerPrefs.GetInt("Value");
        // playerArray[value].SetActive(true);
        player.GetComponent<MeshRenderer>().material = mArray[PlayerPrefs.GetInt("Value")];
    }

    // Update is called once per frame
    void Update()
    {
        playerArray[PlayerPrefs.GetInt("Level")].SetActive(true);
    }
    public void ScenChange()
    {
       

        SceneManager.LoadScene(0);

    }
}
