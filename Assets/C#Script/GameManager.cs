using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject pl;
    public GameObject[] en;
    public GameObject fixen;
    public GameObject wten;
    public bool turnParam;
    private bool EnDelay;
    private float EnDelayTime;


    void Start()
    {
        // インスタンスを生成(既にある場合は破棄)
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);  // シーン読み込みで消えないようにする

        pl = GameObject.Find("Player");
        en = GameObject.FindGameObjectsWithTag("Enemy");
        fixen = GameObject.Find("fixEnemy");
        wten = GameObject.Find("wtEnemy");
        EnDelay = false;
        EnDelayTime = 0;
        turnParam = false;
    }

    void Update()
    {

        if(EnDelayTime >= 0.20f && EnDelay == false)
        {
            EnDelay = true;
        }
        

        if ((Input.GetKeyDown("up") || Input.GetKeyDown("w") 
            || Input.GetKeyDown("down") || Input.GetKeyDown("s")
            || Input.GetKeyDown("left") || Input.GetKeyDown("a")
            || Input.GetKeyDown("right") || Input.GetKeyDown("d")
            || Input.GetKeyDown("space") ) && turnParam == false)
        {
            pl.GetComponent<Player>().Move();
            // Debug.Log("うごいた");
            turnParam = true;
        }

        if (turnParam == true && EnDelay == true)
        {
            for (int x = 0; x < en.Length; ++x)
            {
                en[x].GetComponent<Enemy>().EnemyMove();
            }
            fixen.GetComponent<fixEnemy>().fixEnemyMove();
            wten.GetComponent<WallTracing>().wtEnemyMove();
            turnParam = false;
            EnDelay = false;
            EnDelayTime = 0.0f;
        }
        EnDelayTime += Time.deltaTime;
    }

}
