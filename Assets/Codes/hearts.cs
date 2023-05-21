using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hearts : MonoBehaviour
{

    public Sprite[] HeartSprites;

    public Image HeartUI;

    

    void Start()
    {
       
    }

    void Update()
    {

        HeartUI.sprite = HeartSprites[player.curHealth];

    }
}
