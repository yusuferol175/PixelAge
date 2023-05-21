using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_1 : MonoBehaviour
{
    public float MovementSpeed = 1;

    
    void yandi()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="tas")
        {
            
            GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("yandi", 0.5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="ust")
        {
           

            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            
        }
       
        if (collision.gameObject.tag=="dusman")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        if (collision.gameObject.tag=="kiriktahta")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "dusman3")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }

    }

   
   





    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


        
                if (transform.localScale.x==-0.13f)
                {
                    gameObject.transform.position += new Vector3(1 , 0, 0) * Time.deltaTime * MovementSpeed;
           
                }
                if (transform.localScale.x==0.13f)
                {
                    gameObject.transform.position += new Vector3(-1 , 0, 0) * Time.deltaTime * MovementSpeed;
           
                }
                if (transform.localScale.x == -0.22f)
                 {
                    gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;

                 }
                if (transform.localScale.x == 0.22f)
                {
                 gameObject.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;

                }

        if (transform.localScale.x == 0.19f)
        {
            gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;

        }
        if (transform.localScale.x == -0.19f)
        {
            gameObject.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;

        }

        if (transform.localScale.x == 1f)
        {
            gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;

        }
        if (transform.localScale.x == -1f)
        {
            gameObject.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;

        }


    }



    }

