using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class gecis_sc : MonoBehaviour
{
    private InterstitialAd reklamObjesi;
    void Start()
    {
        MobileAds.Initialize(reklamDurumu => { });
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
        reklamObjesi = new InterstitialAd("ca-app-pub-3940256099942544/1033173712");
        AdRequest reklamIstegi = new AdRequest.Builder().Build();
        reklamObjesi.LoadAd(reklamIstegi);
        

        Debug.Log(PlayerPrefs.GetInt("olumsayisi"));
        if (PlayerPrefs.GetInt("olumsayisi") == 3 || PlayerPrefs.GetInt("olumsayisi") == 6 || PlayerPrefs.GetInt("olumsayisi") == 9)
        {
            StartCoroutine(ReklamiGoster());
        }
        if (PlayerPrefs.GetInt("olumsayisi") == 9)
        {
            PlayerPrefs.SetInt("olumsayisi", 0);
        }
    }
    IEnumerator ReklamiGoster()
    {
        while (!reklamObjesi.IsLoaded())
            yield return null;
        reklamObjesi.Show();
    }
    void OnDestroy()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
    }
}
