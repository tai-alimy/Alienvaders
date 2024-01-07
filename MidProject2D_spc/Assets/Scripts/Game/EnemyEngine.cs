using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyEngine : MonoBehaviour
{

    float transparency;
    SpriteRenderer spriteRenderer;
    int frames;
    int framescur;
    int hits;
    public GameObject enemyFire;
    public GameObject bossFire;
    public GameObject bossFire2;



    // Start is called before the first frame update
    void Start()
    {
        hits = 0;
        frames = 0;
        framescur = 0;
        transparency = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();

        
            Color currentColor = spriteRenderer.color;

            float newAlpha = transparency;
            currentColor.a = newAlpha;
            spriteRenderer.color = currentColor;

        

       

    }

    // Update is called once per frame
    void Update()
    {

        framescur++;
        if (framescur >= 20)
        {
            FireEnemy();
        }
        //enemy is still spawning, not moving yet
        if (transparency < 1)
        {
            if (frames <= 10)
            {
                frames++;
            }

            else 
            {
                frames = 0;
                transparency += 0.2f;

                Color currentColor = spriteRenderer.color;

                float newAlpha = transparency;
                currentColor.a = newAlpha;

                spriteRenderer.color = currentColor;
            }
        }

        


        if (hits >= 2 && ScenesManagement.IsActiveScene("Level1"))
            
        {
            Destroy(gameObject);
            GameStart.enemiesNum--;
            
        }

        else if (hits >= 3 && ScenesManagement.IsActiveScene("Level2"))
        {
            Destroy(gameObject);
            GameStart.enemiesNum--;
        }

        else if (hits >= 50 && ScenesManagement.IsActiveScene("Level3"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("YouWin");
        }

        FireEnemy();



    }



    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            hits++;

            Destroy(collision.gameObject);
        }
    }

    public void FireEnemy()
    {
        if (ScenesManagement.IsActiveScene("Level1"))
        {
            if (Random.Range(0f, 2000f) < 1)
            {
                Instantiate(enemyFire, new Vector3(transform.position.x, transform.position.y - 0.4f, 0), transform.rotation);
            }
        }


        else if (ScenesManagement.IsActiveScene("Level2"))
        {
            if (Random.Range(0f, 1500f) < 1)
            {
                Instantiate(enemyFire, new Vector3(transform.position.x, transform.position.y - 0.4f, 0), transform.rotation);
            }
        }

        else if (ScenesManagement.IsActiveScene("Level3")) 
        {
            if (Random.Range(0f, 500f) < 1)
            {
                
               Instantiate(bossFire, new Vector3(transform.position.x, transform.position.y - 0.4f, 0), transform.rotation);
            }

            if (Random.Range(0f, 900f) < 1)
            {
                Instantiate(bossFire2, new Vector3(transform.position.x, transform.position.y - 1f, 0), transform.rotation);
            }
        }
    }


    





}
