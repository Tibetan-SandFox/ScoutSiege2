using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "UseDoor" && Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
            Debug.Log("�������Ă���");
        }
    }
    */

    void OnTriggerStay2D(Collider2D col)
    {

        if(col.gameObject.tag == "UseDoor")
        {
            Debug.Log("�������Ă���");
        }

        if (Input.GetKey("space") && col.gameObject.tag == "UseDoor")
        {
            Destroy(gameObject);
            Debug.Log("��ꂽ");
        }
    }
}

