using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemintrigger : MonoBehaviour
{
    // Start is called before the first frame update

   // garenkod kr;
    void Start()
    {
        //kr = transform.root.gameObject.GetComponent<garenkod>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D()
    {
        player.yerdemi = true;
    }
    void OnTriggerStay2D()
    {
        player.yerdemi = true;
    }
    void OnTriggerExit2D()
    {
        player.yerdemi = false;
    }
}
