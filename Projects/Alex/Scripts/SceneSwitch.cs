using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();/*grabs the current scene info*/
        public string sceneName = currentScene.name;/*retrieves the current scene name as a string*/
    int i = 0;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            if()
            

        }

        for(i = 0; i<=NumbScenes+1;i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
            targetScene = 
                i++;
                Application.LoadLevel("")/**/
            }
        }
    }
}
