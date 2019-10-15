using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {
    
   
    public string loadScene;

    public void onClick()
    {
       
        if(loadScene=="quit")
        {

            Application.Quit();
        }
        else
        SceneManager.LoadScene(loadScene);
    }
    // Use this for initialization
    void Start () {
        
        
    }
   

    // Update is called once per frame
    void Update () {

     
    }
   

}
