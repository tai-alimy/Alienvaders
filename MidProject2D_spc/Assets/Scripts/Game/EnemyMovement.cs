using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMovement : MonoBehaviour
{
    float speed;
    
    float timer;
    float interval;
    int numOfMoves;
    // Start is called before the first frame update
    void Start()
    {
        interval = 0.1f;
        speed = 0.1f;
        numOfMoves = 0;
    }

    // Update is called once per frame
    void Update()
    {

        

        if (SceneManager.GetSceneByName("Level2") == SceneManager.GetActiveScene())
        {
            timer += Time.deltaTime;

            if (timer > interval)
            {
                transform.Translate(new Vector3(speed, 0, 0));

                timer = 0;
                numOfMoves++;
            }


            if (numOfMoves == 12)
            {
                transform.Translate(new Vector3(0, speed*2, 0));
                numOfMoves = 0;
                speed = -speed;

            }
        }


        if (SceneManager.GetSceneByName("Level3") == SceneManager.GetActiveScene())
        {

            timer += Time.deltaTime;

            if (timer > interval)
            {
                transform.Translate(new Vector3(speed*4, 0, 0));

                timer = 0;
                numOfMoves++;
            }


            if (numOfMoves == 20)
            {
                transform.Translate(new Vector3(0, speed * 3, 0));
                numOfMoves = 0;
                speed = -speed;

            }



        }





    }
}
