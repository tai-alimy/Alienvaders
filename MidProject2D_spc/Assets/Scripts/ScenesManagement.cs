using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    public static bool IsActiveScene(string sceneName)
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName(sceneName))
        {
            return true;
        }

        return false;
    }


}
