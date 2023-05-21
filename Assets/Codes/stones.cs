using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stones : MonoBehaviour
{

    public Sprite[] StoneSprites;

    public Image StoneUI;



    void Start()
    {

    }

    void Update()
    {

        StoneUI.sprite = StoneSprites[player.curStones];

    }
}
