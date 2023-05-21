using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject[] dusman3;


    Animator anim;
    bool a;

    public static Vector3 chkpnt;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (a)
        {
            if (collision.gameObject.tag == "Player")
            {
                
                chkpnt = player.bekko.transform.position;
                PlayerPrefs.SetFloat("xc", chkpnt.x);
                PlayerPrefs.SetFloat("yc", chkpnt.y);
                PlayerPrefs.SetFloat("zc", chkpnt.z);

                anim.SetBool("degdi", true);

                
                a = false;
            }
        }
        
       
    }

   
    // Start is called before the first frame update
    void Start()
    {
        

        anim = GetComponent<Animator>();
        a = true;

        

    }

    // Update is called once per frame
    void Update()
    {
        
        

       

    }
}
