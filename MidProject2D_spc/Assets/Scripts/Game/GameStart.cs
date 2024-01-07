using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

     public static int enemiesNum;
    // Start is called before the first frame update
    void Start()
    {
        enemiesNum = 21;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (enemiesNum <= 0&& ScenesManagement.IsActiveScene("Level1"))
        {
            SceneManager.LoadScene("Level2");
            enemiesNum = 21;

        }

        else if (enemiesNum <= 0 && ScenesManagement.IsActiveScene("Level2"))
        {
            SceneManager.LoadScene("Level3");
            enemiesNum = 1;

        }

        else if (enemiesNum <= 0 && ScenesManagement.IsActiveScene("Level3"))
        {
            SceneManager.LoadScene("YouWin");
            

        }



    }
}
