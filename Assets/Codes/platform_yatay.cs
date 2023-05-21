using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_yatay : MonoBehaviour
{
    PlayerPrefsException playerprefs;

    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    public GameObject karakter;

    Vector3 nextPos;

    void setparent()
    {
        karakter.transform.SetParent(null);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player" && player.yerdemi == true)
        {
            collision.transform.SetParent(transform);
        }

        karakter = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("ailed�s�", 1f);
        }
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;

      
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position==pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position==pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position,pos2.position);
    }
}
