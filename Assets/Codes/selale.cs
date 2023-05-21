using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selale : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dinazor;
    public GameObject dinazor2;
    public GameObject dusman3;
    public GameObject kiriktahta;

    private void OnCollisionEnter2D(Collision2D sertcarpma)
    {


        if (sertcarpma.gameObject.tag == "dusman")
        {

            Destroy(sertcarpma.gameObject);



        }
        if (sertcarpma.gameObject.tag == "dusman2")
        {


            Destroy(sertcarpma.gameObject);


        }
 

        if (sertcarpma.gameObject.tag == "dusman3")
        {
            Destroy(sertcarpma.gameObject);



        }
        
        if (sertcarpma.gameObject.tag == "kiriktahta")
        {
            Destroy(sertcarpma.gameObject);

        }

    }
    void Start()
    {
        dinazor = GameObject.Find("dinazor");

        dinazor2 = GameObject.Find("dinazor2");

        dusman3 = GameObject.Find("dusman3");

        kiriktahta = GameObject.Find("kiriktahta");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
