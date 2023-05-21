using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bosskod : MonoBehaviour
{
    public GameObject dinazor;
    public GameObject dinazor2;
    public GameObject bekko;
    public GameObject kalp;
    public static GameObject boss;
    public GameObject dusman3;
    

  
    private void OnCollisionEnter2D(Collision2D sertcarpma)
    {

       


        if (sertcarpma.gameObject.tag == "Player")
        {

            player.curHealth = 0;
            Destroy(sertcarpma.gameObject);


        }

        if(sertcarpma.gameObject.tag == "dusman")
        {

            Destroy(sertcarpma.gameObject);
            
           

        }
        if (sertcarpma.gameObject.tag == "dusman2")
        {

            
            Destroy(sertcarpma.gameObject);
           

        }
        if (sertcarpma.gameObject.tag == "ust")
        {
            Destroy(sertcarpma.gameObject);
            
        }
       
        if (sertcarpma.gameObject.tag == "dusman3")
        {
            Destroy(sertcarpma.gameObject);



        }
        if (sertcarpma.gameObject.tag=="buyuk_toprak")
        {
            Destroy(sertcarpma.gameObject);
        }
        if (sertcarpma.gameObject.tag == "platform")
        {

            
            bekko.gameObject.transform.SetParent(null);
            Destroy(sertcarpma.gameObject.transform.parent.gameObject);
            

        }
        if (sertcarpma.gameObject.tag=="kiriktahta")
        {
            Destroy(sertcarpma.gameObject.transform.parent.gameObject);
        }
        if (sertcarpma.gameObject.tag == "kaktus")
        {
            Destroy(sertcarpma.gameObject);
        }
        if (sertcarpma.gameObject.tag == "trap")
        {
            Destroy(sertcarpma.gameObject);
        }
        if (sertcarpma.gameObject.tag == "kapi1")
        {
            Destroy(sertcarpma.gameObject);
        }
        if (sertcarpma.gameObject.tag == "kapi2")
        {
            Destroy(sertcarpma.gameObject);
        }

    }
    



    void Start()
    {
        dinazor = GameObject.Find("dinazor");

        dinazor2 = GameObject.Find("dinazor2");

        bekko = GameObject.Find("berkay");

        kalp = GameObject.Find("kalp");

        boss = GameObject.Find("boss");

        dusman3 = GameObject.Find("dusman3");

        
    }

    
    void Update()
    {
        gameObject.transform.position += new Vector3(4*Time.deltaTime, 0, 0);
    }
}
