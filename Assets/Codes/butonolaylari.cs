using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class butonolaylari : MonoBehaviour
{
    [SerializeField]
    public GameObject tas;
    public GameObject pause;
    public GameObject level;  
    public GameObject giris;
    public GameObject kamera;


    [SerializeField]
    AudioClip tas_sound;
    [SerializeField]
    AudioClip jump_sound;
    AudioSource ses;
    
   

    public float MovementSpeed = 1;
    public GameObject bekko;

    
    public bool oyundurdumu = false;
    public bool oldumu = false;
    bool hareket;

    
   
    public void play()
    {
      
        giris.gameObject.SetActive(false);
        level.gameObject.SetActive(true);
        

    }

    public void menubuton()
    {
        PlayerPrefs.SetInt("bannerdurum", 0);
        SceneManager.LoadScene("menu");
        

    }
    void yukle()
    {
        

        checkpoint.chkpnt.x = PlayerPrefs.GetFloat("xc");
        checkpoint.chkpnt.y = PlayerPrefs.GetFloat("yc");
        checkpoint.chkpnt.z = PlayerPrefs.GetFloat("zc");



        Vector3 loadPos = new Vector3(checkpoint.chkpnt.x, checkpoint.chkpnt.y, bekko.gameObject.transform.localPosition.z);
        Vector3 loadPosBoss = new Vector3(checkpoint.chkpnt.x -25, 2.2f, -8f);
        Vector3 loadPosCam = new Vector3(checkpoint.chkpnt.x , 1.905753f, -35.83132f);

        if (bekko.gameObject)
        {
            player.bekko.transform.position = loadPos;
            bosskod.boss.transform.position = loadPosBoss;
            kamera.transform.position = loadPosCam;
            
        }
       

    }
    public void restartbuton()
    {
        if (PlayerPrefs.GetInt("strylvl")==1)
        {
            SceneManager.LoadScene("ilk_oyun");
        }
        if (PlayerPrefs.GetInt("strylvl") == 2)
        {
            SceneManager.LoadScene("misir");
        }

    }

    public void pausebuton()
    {
        if (oyundurdumu==false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;
        }
        else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
        
        pause.gameObject.SetActive(true);
      
    }

    public void oyunudurdur()
    {
        if (oyundurdumu==true)
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
        pause.gameObject.SetActive(false);
        oldumu = false;
    }
    
    
    
    


    public void ates()
    {
       

        

        
        if (player.curStones > 0 && player.sagats == true)
        {

            ses.PlayOneShot(tas_sound);

            var spawntas = Instantiate(tas, player.taskonum.transform.position, player.taskonum.transform.rotation);

            spawntas.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500f);

            player.curStones -= 1;
            
            player.animcha.SetBool("ates", true);

        }

        if (player.curStones > 0 && player.solats == true)
        {

            ses.PlayOneShot(tas_sound);

            var spawntas = Instantiate(tas, player.taskonum.transform.position, player.taskonum.transform.rotation);

            spawntas.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 500f);

            player.curStones -= 1;

            player.animcha.SetBool("ates", true);

        }
        

    }
    
    
    public void zipla()
    {
        if (player.bekko)
        {
            if (player.yerdemi == true)
            {
                ses.PlayOneShot(jump_sound);
                
                player._rigidbody.AddForce(new Vector2(0, player.JumpForce * 9), ForceMode2D.Impulse);

                
            }

            
            
        }
        
    }
   
    public void move_start(bool sol_da_mi)
    {
        if (sol_da_mi)
        {
            if (bekko.transform.localScale.x > 0)
            {
                bekko.transform.localScale = new Vector3(bekko.transform.localScale.x * -1, bekko.transform.localScale.y, bekko.transform.localScale.x);
                MovementSpeed *= -1;
            }
            
            player.solats = true;
            player.sagats = false;
        }
        else
        {
            if (bekko.transform.localScale.x < 0)
            {
                bekko.transform.localScale = new Vector3(bekko.transform.localScale.x * -1, bekko.transform.localScale.y, bekko.transform.localScale.x);
                MovementSpeed *= -1;
            }

            player.sagats = true;
            player.solats = false;
        }

        hareket = true;
    }
    public void move_stop()
    {
        hareket = false;
        
    }

    public void Start()
    {
        bekko = GameObject.Find("berkay");

        pause = GameObject.Find("pause");

        level = GameObject.Find("level");

        giris = GameObject.Find("giris");


        kamera = GameObject.Find("Main Camera");

        ses = GetComponent<AudioSource>();


        
        Invoke("yukle", 0.001f);


        Time.timeScale = 1f;

        player.curHealth = 3;
        
        pause.gameObject.SetActive(false);


        
            
        



    }

    private void LateUpdate()
    {
        if (player.animcha)
        {
            if (player.animcha.GetBool("ates") == true)
            {
                player.animcha.SetBool("ates", false);
            }
            
        }
        
    }

   
    private void Update()
    {
       
       
        if (bekko.gameObject)
        {
            if (player.yerdemi == false)
            {
                player.animcha.SetBool("havada", true);
            }
            else
            {
                player.animcha.SetBool("havada", false);
            }
        }
        

        
            if (hareket)
            {
                if (bekko.gameObject) {

                    bekko.transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime * 5;

                }
                
                if (player.animcha)
                {
                    if (player.animcha.GetBool("havada") == false)
                    {
                        player.animcha.SetBool("yurume", true);
                    }
                    else
                    {
                        player.animcha.SetBool("havada", true);
                    }


                }




            }
            else
            {
                if (player.animcha)
                {
                    player.animcha.SetBool("yurume", false);
                }


            }
            if (oldumu == false)
            {
                if (player.curHealth == 0)
                {
                PlayerPrefs.SetInt("anahtarvar", 0);
                oldumu = true;
                    if (oldumu == true)
                    {
                    int olum = PlayerPrefs.GetInt("olumsayisi") + 1;
                    PlayerPrefs.SetInt("olumsayisi",olum);

                    SceneManager.LoadScene("olum");
                    oyundurdumu = true;
                        
                        
                    }

                }
            }
        

        
        



    }
    
}