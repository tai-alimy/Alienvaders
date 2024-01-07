using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    float speed;
    int xDir;
    int yDir;
    public static int lives;
    float interval;
    float transparency;
    
    SpriteRenderer spriteRenderer;
    public GameObject[] hearts = new GameObject[3];


    public GameObject firePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
        lives = 3;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (lives == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        xDir = 0;
        yDir = 0;

        if (Input.GetKey(KeyCode.RightArrow)){
            xDir += 1;

        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            xDir -=1;
            
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            yDir += 1;

        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            yDir -= 1;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Quaternion rotation = firePrefab.transform.rotation;
            Quaternion rotation2 = firePrefab.transform.rotation;

            rotation.eulerAngles.Set(0, 0, 175);
            rotation2.eulerAngles.Set(0, 0, -90);

            Instantiate(firePrefab, transform.position, rotation);
           // Instantiate(firePrefab, transform.position, rotation2);

        }


        transform.position = new Vector2(transform.position.x + xDir * speed * Time.deltaTime, transform.position.y + yDir * speed * Time.deltaTime);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && lives>0)
        {
            lives -= 1;
            Destroy(hearts[lives]);
            transform.position = new Vector3(0, -4f,0);

           
        }


        if (collision.gameObject.tag == "EnemyFire")
        {
            lives -= 1;
            Destroy(hearts[lives]);
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "Boss2" )
        {
          
            lives = 0;
            Destroy(collision.gameObject);
        }

    }





}
