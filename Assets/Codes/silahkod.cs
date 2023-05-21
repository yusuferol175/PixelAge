using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class silahkod : MonoBehaviour
{
    [SerializeField]
    public GameObject tas;


    public GameObject bekko;
    


    
  
    private void OnTriggerEnter2D(Collider2D yumusakcarpma)
    {
        

        if (yumusakcarpma.gameObject.tag == "dusman")
        {
            
            Destroy(yumusakcarpma.gameObject.transform.parent);
            if (yumusakcarpma.gameObject.GetComponent<CircleCollider2D>().enabled == false)
            {
                Destroy(yumusakcarpma.gameObject);
               
            }
            yumusakcarpma.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            
            

            Destroy(tas);


        }




        if (yumusakcarpma.gameObject.tag == "dusman2" )
        {
            

            Destroy(yumusakcarpma.gameObject);
            Destroy(tas);
        }

        if (yumusakcarpma.gameObject.tag == "boss" )
        {
            
            Destroy(tas);

        }
        if (yumusakcarpma.gameObject.tag == "dusman3" )
        {


            Destroy(yumusakcarpma.gameObject);
            Destroy(tas);

        }
        if (yumusakcarpma.gameObject.tag=="ust")
        {
            Destroy(tas);
        }
        if (yumusakcarpma.gameObject.tag == "kaktus")
        {
            Destroy(tas);
        }
    }

    void Start()
    {
        Destroy(gameObject, 2f);



        bekko = GameObject.Find("berkay");

       

        
       
    }

    
    void Update()
    {
      


    }
}
