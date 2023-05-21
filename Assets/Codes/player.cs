using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class player : MonoBehaviour
{
    [SerializeField]
    public GameObject tas;

    public static GameObject[] dinazor;
    public static GameObject bekko;
    public GameObject tas1;
    public GameObject kalp;
    public GameObject boss; 
    public GameObject[] dinazor2;
    public static GameObject[] dusman3;
    public GameObject selale;
    public static GameObject taskonum;
    public GameObject[] kiriktahta;
    public static GameObject[] asansor;
    public static GameObject[] asansorust;
    public GameObject kapan;
    

    public static bool solats = false;
    public static bool sagats = true;
    public static bool yerdemi;
    public bool hasaryeme = false;

    public static string level2="level2";
    public static string level3="level3";

    public Rigidbody2D rTahta;
    public static Rigidbody2D _rigidbody;
    public float MovementSpeed = 1;
    public static float JumpForce = 1;
    public static int curHealth;
    public int maxHealth;
    public static int curStones;
    public int maxStones;

    public static Animator animcha;


   
    private void OnTriggerEnter2D(Collider2D yumusakcarpma)
    {
        if (yumusakcarpma.gameObject.tag == "can")
        {
         

            if (curHealth < 3)
            {
                curHealth++;
                
                if (curHealth == maxHealth)
                {
                    curHealth = maxHealth;
                }
            }

            Destroy(yumusakcarpma.gameObject);
        }

        

        if (yumusakcarpma.gameObject.tag == "tas1")
        {
            if (curStones < 5)
            {
                curStones++;

                if (curStones == maxStones)
                {
                    curStones = maxStones;
                }
            }

            Destroy(yumusakcarpma.gameObject);

        }


        if (yumusakcarpma.gameObject.tag=="zaman_mak")
        {
            PlayerPrefs.SetString("level2", level2);
            PlayerPrefs.SetInt("tstry", 0);
            PlayerPrefs.SetInt("tstryson", 1);
            SceneManager.LoadScene("menu");

            
            PlayerPrefs.DeleteKey("xc");
            PlayerPrefs.DeleteKey("yc");
            PlayerPrefs.DeleteKey("zc");
            
        }
        if (yumusakcarpma.gameObject.tag == "zaman_mak_misir")
        {
            PlayerPrefs.SetInt("yakinda", 1);
            PlayerPrefs.SetString("level3", level3);
            PlayerPrefs.SetInt("tstry", 0);
            PlayerPrefs.SetInt("tstryson", 1);
            SceneManager.LoadScene("menu");


            PlayerPrefs.DeleteKey("xc");
            PlayerPrefs.DeleteKey("yc");
            PlayerPrefs.DeleteKey("zc");

        }
        if (yumusakcarpma.gameObject.tag == "anahtar")
        {
            PlayerPrefs.SetInt("anahtarvar", 1);
            Destroy(yumusakcarpma.gameObject);

        }
        if (yumusakcarpma.gameObject.tag=="bayrak")
        {
            Destroy(yumusakcarpma.gameObject.GetComponent<BoxCollider2D>());
        }
        if (yumusakcarpma.gameObject.tag=="kapan")
        {
            kapan.gameObject.SetActive(true);
            Destroy(yumusakcarpma.gameObject);
        }
        if (yumusakcarpma.gameObject.tag == "dusman2")
        {

            if (hasaryeme == false)
            {
                curHealth = curHealth - 1;
            if (curHealth <= 0)
            {
                curHealth = 0;
            }
            
            GetComponent<SpriteRenderer>().color = Color.red;
            }
            hasaryeme = true;
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 0.5f);
        }
    }

    
    void duzelt()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        
    }
    void hasaryemeha()
    {
        hasaryeme = false;
    }

    private void OnCollisionEnter2D(Collision2D sertcarpma)
    {
        if (sertcarpma.gameObject.tag=="kapi1")
        {
            if (PlayerPrefs.GetInt("anahtarvar") ==1)
            {
                sertcarpma.gameObject.SetActive(false);
               
                PlayerPrefs.SetInt("anahtarvar", 0);
            }
            
        }
        if (sertcarpma.gameObject.tag == "kapi2")
        {
            if (PlayerPrefs.GetInt("anahtarvar") == 1)
            {
                sertcarpma.gameObject.SetActive(false);
              
                PlayerPrefs.SetInt("anahtarvar", 0);
            }

        }
        if (sertcarpma.gameObject.tag == "boss")
        {


            curHealth = curHealth-3;
            if (curHealth <= 0)
            {
                curHealth = 0;
            }


        }

        if (sertcarpma.gameObject.tag == "dusman")
        {
            if (hasaryeme==false)
            {
                curHealth = curHealth - 1;
                if (curHealth <= 0)
                {
                    curHealth = 0;
                }

                _rigidbody.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
                GetComponent<SpriteRenderer>().color = Color.red;
            }
            hasaryeme = true;
            
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 0.5f);
        }

        if (sertcarpma.gameObject.tag=="kaktus")
        {
            if (hasaryeme == false)
            {
                curHealth = curHealth - 1;
                if (curHealth <= 0)
                {
                    curHealth = 0;
                }
                _rigidbody.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
                GetComponent<SpriteRenderer>().color = Color.red;
            }
            hasaryeme = true;
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 0.5f);
        }
        if (sertcarpma.gameObject.tag=="trap")
        {
            if (hasaryeme == false)
            {
                curHealth = curHealth - 2;
                if (curHealth <= 0)
                {
                    curHealth = 0;
                }
                _rigidbody.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
                GetComponent<SpriteRenderer>().color = Color.red;
            }
            hasaryeme = true;
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 0.5f);
        }
        if (sertcarpma.gameObject.tag == "dusman3")
        {

            if (hasaryeme == false)
            {
                curHealth = curHealth - 1;
            if (curHealth <= 0)
            {
                curHealth = 0;
            }
            _rigidbody.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
            GetComponent<SpriteRenderer>().color = Color.red;
            }
            hasaryeme = true;
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 0.5f);
        }
        if (sertcarpma.gameObject.tag =="selale")
        {
            curHealth = curHealth - 3;
            if (curHealth <= 0)
            {
                curHealth = 0;
            }

            

        }

        if (sertcarpma.gameObject.tag=="kiriktahta")
        {
            sertcarpma.gameObject.GetComponent<Rigidbody2D>().isKinematic=false;

        }


    }

    
    void Start()
    {
        
        //PlayerPrefs.DeleteKey("level2");
        

        dinazor = GameObject.FindGameObjectsWithTag("dusman");

        dinazor2 = GameObject.FindGameObjectsWithTag("dusman2");
     
        dusman3 = GameObject.FindGameObjectsWithTag("dusman3");


        bekko = GameObject.Find("berkay");

        tas1 = GameObject.Find("tas1");

        kalp = GameObject.Find("kalp");

        boss = GameObject.Find("boss");

        kapan = GameObject.Find("ustkapan");

        selale = GameObject.Find("selale");

        taskonum = GameObject.Find("konum");

        asansor = GameObject.FindGameObjectsWithTag("asansor");

        asansorust = GameObject.FindGameObjectsWithTag("asansorust");

        kiriktahta = GameObject.FindGameObjectsWithTag("kiriktahta");


        _rigidbody = GetComponent<Rigidbody2D>();

        curStones = 5;
        curHealth = 3;

        sagats = true;
        solats = false;
       
        kapan.gameObject.SetActive(false);
        
        

        animcha = GetComponent<Animator>();
        foreach (var ktt in kiriktahta)
        {
            ktt.GetComponent<Rigidbody2D>().isKinematic = true;
           
        }
        
    }

    
    void Update()
    {

        if (bekko.gameObject)
        {
            


            foreach (var dk in dinazor2)
            {
                if (dk.gameObject)
                {
                    dk.gameObject.transform.position += new Vector3(-2, 0, 0) * Time.deltaTime * MovementSpeed;
                }
            }

            
            
        }
            


    }

   
}
