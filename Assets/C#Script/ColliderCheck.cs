using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColliderCheck : MonoBehaviour
{
    public GameObject pl;
    public LayerMask groundLayer1;
    public LayerMask groundLayer2;

    // Update is called once per frame
    void Update()
    {
        //wall_Check();
    }

    public void wall_Check()
    {
        pl = GameObject.Find("Player");
        if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            RaycastHit2D upHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, groundLayer1);  //上に対象のレイヤーの物があるか確認
            if (upHit.collider == null) { pl.GetComponent<Player>().Move(); Debug.Log(upHit.collider); }
            else { Debug.Log(upHit.collider); }
        }

        if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            RaycastHit2D downHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.down, 1, groundLayer1);
            if (downHit.collider == null) { pl.GetComponent<Player>().Move(); }
            else { }
        }

        if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            RaycastHit2D leftHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.left, 1, groundLayer1);
            if (leftHit.collider == null) { pl.GetComponent<Player>().Move(); }
            else { }
        }

        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            RaycastHit2D rightHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.right, 1, groundLayer1);
            if (rightHit.collider == null) { pl.GetComponent<Player>().Move(); }
            else { }
        }
    }

    public void enemy_Check()
    {
        RaycastHit2D enemyHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, groundLayer2);  //上に対象のレイヤーの物があるか確認

    }
}
