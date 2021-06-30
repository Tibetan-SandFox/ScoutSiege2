using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WallTracing : MonoBehaviour
{
    public GameObject wt;
    public LayerMask groundLayer;
    public Vector2 SPEED = new Vector2(1.0f, 1.0f);
    int count = 0;
    int time = 0;

    void start()
    {
        wt = GameObject.Find("wtEnemy");
    }

    void Update()
    {
        // wtEnemyMove();
    }

    public void wtEnemyMove()
    {
        Transform myTransform = this.transform;
        Vector2 Position = transform.position;

        //上向いてるとき
        if (transform.localEulerAngles.z == 0)
        {
            //左
            if (count == 0)
            {
                RaycastHit2D leftHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.left, 1, groundLayer);
                if (leftHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.x -= SPEED.x;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90);
                    count = 0;
                }
                else { count++; }
            }
            else if (count == 1)
            {
                //上
                RaycastHit2D upHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, groundLayer);
                if (upHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.y += SPEED.y;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
                    count = 0;
                }
                else { count++; }
            }
            else if (count == 2)
            {
                //右
                RaycastHit2D rightHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.right, 1, groundLayer);
                if (rightHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.x += SPEED.x;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270);
                    count = 0;
                }
                else { count++; }
            }
        }
        //右向いてるとき
        if (transform.localEulerAngles.z == 270)
        {
            if (count == 0)
            {
                //左
                RaycastHit2D upHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, groundLayer);
                if (upHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.y += SPEED.y;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
                    count = 0;
                }
                else { count++; }
                
            }
            else if (count == 1)
            {
                //上
                RaycastHit2D rightHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.right, 1, groundLayer);
                if (rightHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.x += SPEED.x;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270);
                    count = 0;
                }
                else { count++; }
            }
            else if (count == 2)
            {
                //右
                RaycastHit2D downHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.down, 1, groundLayer);
                if (downHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.y -= SPEED.y;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180);
                    count = 0;
                }
                else { count++; }
            }
        }
        //下向いてるとき
        if (transform.localEulerAngles.z == 180)
        {
            if (count == 0)
            {
                //左
                RaycastHit2D rightHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.right, 1, groundLayer);
                if (rightHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.x += SPEED.x;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270);
                    count = 0;
                }
                else { count++; }
            }
            else if (count == 1)
            {
                //上
                RaycastHit2D downHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.down, 1, groundLayer);
                if (downHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.y -= SPEED.y;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180);
                    count = 0;
                }
                else { count++; }                
            }
            else if (count == 2)
            {
                //右
                RaycastHit2D leftHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.left, 1, groundLayer);
                if (leftHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.x -= SPEED.x;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90);
                    count = 0;
                }
                else { count++; }                
            }
        }
        //左向いてるとき
        if (transform.localEulerAngles.z == 90)
        {
            //左
            if (count == 0)
            {
                RaycastHit2D downHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.down, 1, groundLayer);
                if (downHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.y -= SPEED.y;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180);
                    count = 0;
                }
                else { count++; }
                
            }
            else if (count == 1)
            {
                //上
                RaycastHit2D leftHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.left, 1, groundLayer);
                if (leftHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.x -= SPEED.x;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90);
                    count = 0;
                }
                else { count++; }                
            }
            else if (count == 2)
            {
                //右
                RaycastHit2D upHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, groundLayer);
                if (upHit.collider == null)
                {
                    System.Threading.Thread.Sleep(time);
                    Position.y += SPEED.y;
                    transform.position = Position;
                    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
                    count = 0;
                }
                else { count++; }                
            }
        }
    }
}
