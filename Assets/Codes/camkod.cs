using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camkod : MonoBehaviour
{

    public Transform CamTransform;
    public Transform bekko;
    public float followspeed;
    public GameObject beko; 

    void Start()
    {
        CamTransform = Camera.main.transform;
        bekko = GameObject.Find("berkay").transform;
        beko = GameObject.Find("berkay");
    }

    void Update()
    {
        if (beko.gameObject)
        {
            Vector3 targetPosition = new Vector3(bekko.position.x, CamTransform.position.y, CamTransform.position.z);

            CamTransform.position = Vector3.Lerp(CamTransform.position, targetPosition, Time.deltaTime * followspeed);
        }
        
    }
}
