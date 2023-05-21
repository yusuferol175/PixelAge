using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buton_olay_olum : MonoBehaviour
{
    public GameObject olum_im;
    public Sprite lvl1_im;
    public Sprite lvl2_im;
    public void menubuton()
    {
        if (PlayerPrefs.GetInt("reklamvar")==1)
        {

        }
        else
        {
            PlayerPrefs.SetInt("bannerdurum", 0);
            SceneManager.LoadScene("menu");

        }


    }
    public void restartbuton()
    {
        if (PlayerPrefs.GetInt("reklamvar") == 1)
        {

        }
        else
        {
            if (PlayerPrefs.GetInt("strylvl") == 1)
            {
                SceneManager.LoadScene("ilk_oyun");
            }
            if (PlayerPrefs.GetInt("strylvl") == 2)
            {
                SceneManager.LoadScene("misir");
            }
        }
        

    }

    public void reklamvar()
    {
        PlayerPrefs.SetInt("reklamvar", 0);
    }
     void Start()
    {
        if (PlayerPrefs.GetInt("olumsayisi") == 3 || PlayerPrefs.GetInt("olumsayisi") == 6 || PlayerPrefs.GetInt("olumsayisi") == 9)
        {
            PlayerPrefs.SetInt("reklamvar", 1);
            Invoke("reklamvar", 1f);
        }
        if (PlayerPrefs.GetInt("strylvl") == 1)
        {
            olum_im.gameObject.GetComponent<Image>().sprite = lvl1_im;
        }
        if (PlayerPrefs.GetInt("strylvl") == 2)
        {
            olum_im.gameObject.GetComponent<Image>().sprite = lvl2_im;
        }
    }

}
