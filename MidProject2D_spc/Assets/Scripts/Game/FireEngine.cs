using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEngine : MonoBehaviour
{
    public Transform playScale;
    float speed;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        transform.rotation.Set(0, 0,1, -25);


        speed = 7;
        playScale = GameObject.Find("Player").transform;

        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
      // rb.AddForce(new Vector2(100, 100));

         transform.Translate(0, speed * Time.deltaTime,0);



    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
