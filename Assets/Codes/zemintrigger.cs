using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemintrigger : MonoBehaviour
{
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
