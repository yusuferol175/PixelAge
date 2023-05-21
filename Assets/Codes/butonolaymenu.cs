using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class butonolaymenu : MonoBehaviour
{
    public GameObject yakinda;
    public GameObject storyilk;
    public GameObject shn1;
    public GameObject shn2;
    public GameObject shn3;
    public GameObject shn4;
    public GameObject storyson;
    public GameObject shns1;
    public GameObject shns2;
    public GameObject shns3;
    public GameObject shns4;


    public Sprite lvl1_1;
    public Sprite lvl1_2;
    public Sprite lvl1_3;
    public Sprite lvl1_4;

    public Sprite lvl2_1;
    public Sprite lvl2_2;
    public Sprite lvl2_3;
    public Sprite lvl2_4;


    public Sprite lvl1s_1;
    public Sprite lvl1s_2;
    public Sprite lvl1s_3;
    public Sprite lvl1s_4;

    public Sprite lvl2s_1;
    public Sprite lvl2s_2;
    public Sprite lvl2s_3;
    public Sprite lvl2s_4;



    public GameObject level;
    public GameObject giris;
    public static GameObject level2;
    public void play()
    {
        

        giris.gameObject.SetActive(false);
        level.gameObject.SetActive(true);
    }

    int shnsayar = 0;
    int shnsayarson = 0;
    public void nextbut()
    {
        

            if (shnsayar==0)
            {
                shn2.SetActive(true);
                
            }
            if (shnsayar == 1)
            {
                shn3.SetActive(true);
                
            }
            if (shnsayar == 2)
            {
                shn4.SetActive(true);
                
            }
            if (shnsayar == 3)
            {
                PlayerPrefs.SetInt("tstry", 1);

            if (PlayerPrefs.GetInt("strylvl") == 1)
            {
                SceneManager.LoadScene("ilk_oyun");
            }
            if (PlayerPrefs.GetInt("strylvl") == 2)
            {
                SceneManager.LoadScene("misir");
            }


        }

        shnsayar = shnsayar + 1;

    }
    public void nextbutson()
    {
        if (shnsayarson == 0)
        {
            shns2.SetActive(true);

        }
        if (shnsayarson == 1)
        {
            shns3.SetActive(true);

        }
        if (shnsayarson == 2)
        {
            shns4.SetActive(true);

        }
        if (shnsayarson == 3)
        {
            PlayerPrefs.SetInt("tstryson", 0);
            storyson.SetActive(false);

        }

        shnsayarson = shnsayarson + 1;
    }
    public void menubuton()
    {

        giris.gameObject.SetActive(true);
        level.gameObject.SetActive(false);

        PlayerPrefs.SetInt("bannerdurum", 0);
    }
    public void level1()
    {
        PlayerPrefs.SetInt("bannerdurum", 1);
        PlayerPrefs.SetInt("strylvl", 1);

        shn1.gameObject.GetComponent<Image>().sprite = lvl1_1;
        shn2.gameObject.GetComponent<Image>().sprite = lvl1_2;
        shn3.gameObject.GetComponent<Image>().sprite = lvl1_3;
        shn4.gameObject.GetComponent<Image>().sprite = lvl1_4;

       
        if (PlayerPrefs.GetInt("tstry") == 1)
        {
            SceneManager.LoadScene("ilk_oyun");
        }
        else
        {
            
            storyilk.SetActive(true);
            shn2.SetActive(false);
            shn3.SetActive(false);
            shn4.SetActive(false);
        }
        //SceneManager.LoadScene("ilk_oyun");
        

    }
    public void levelmisir()
    {
        PlayerPrefs.SetInt("bannerdurum", 1);
        PlayerPrefs.SetInt("strylvl", 2);

        shn1.gameObject.GetComponent<Image>().sprite = lvl2_1;
        shn2.gameObject.GetComponent<Image>().sprite = lvl2_2;
        shn3.gameObject.GetComponent<Image>().sprite = lvl2_3;
        shn4.gameObject.GetComponent<Image>().sprite = lvl2_4;

        
        if (PlayerPrefs.GetInt("tstry") == 1)
        {
            SceneManager.LoadScene("misir");
        }
        else
        {

            storyilk.SetActive(true);
            shn2.SetActive(false);
            shn3.SetActive(false);
            shn4.SetActive(false);
        }
        
    }
    public void yakinda_kapa()
    {
        yakinda.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
        

        storyilk.gameObject.SetActive(false);

        level = GameObject.Find("level");

        giris = GameObject.Find("giris");

        level2 = GameObject.Find("level2");

        //level2.gameObject.SetActive(false);
        if (PlayerPrefs.GetString("level2") == player.level2)
        {
            level2.gameObject.SetActive(true);
        }
        else
        {
            level2.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetString("level3") == player.level3)
        {
            
            
        }
        else
        {
           
        }
        if (PlayerPrefs.GetInt("yakinda") == 0)
        {
            yakinda.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("yakinda")==1)
        {
            yakinda.gameObject.SetActive(true);
            PlayerPrefs.SetInt("yakinda", 0);
        }
        
        if (PlayerPrefs.GetInt("tstryson")==1)
        {
            if (PlayerPrefs.GetInt("strylvl")==1)
            {
                
                shns1.gameObject.GetComponent<Image>().sprite = lvl1s_1;
                shns2.gameObject.GetComponent<Image>().sprite = lvl1s_2;
                shns3.gameObject.GetComponent<Image>().sprite = lvl1s_3;
                shns4.gameObject.GetComponent<Image>().sprite = lvl1s_4;

                storyson.SetActive(true);

                shns2.SetActive(false);
                shns3.SetActive(false);
                shns4.SetActive(false);
            }
            if (PlayerPrefs.GetInt("strylvl") == 2)
            {
                
                shns1.gameObject.GetComponent<Image>().sprite = lvl2s_1;
                shns2.gameObject.GetComponent<Image>().sprite = lvl2s_2;
                shns3.gameObject.GetComponent<Image>().sprite = lvl2s_3;
                shns4.gameObject.GetComponent<Image>().sprite = lvl2s_4;

                storyson.SetActive(true);

                shns2.SetActive(false);
                shns3.SetActive(false);
                shns4.SetActive(false);
            }
            //PlayerPrefs.SetInt("tstryson", 0);
        }
        else
        {
           
            storyson.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
