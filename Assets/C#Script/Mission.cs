using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour
{
    public GameObject miManager;

    // Start is called before the first frame update
    void Start()
    {
        miManager = GameObject.Find("GameManager");

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            miManager.GetComponent<MissionManager>().mManager();

        }
    }
}
