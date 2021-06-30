using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
	public Vector2 SPEED = new Vector2(1.0f, 1.0f);

    public LayerMask groundLayer1;
    public LayerMask groundLayer2;

    void Start()
    {
        
    }

    void Update()
    {
        // EnemyMove();
    }
    public void EnemyMove()
    {
        Vector2 Position = transform.position;
        int rnd = UnityEngine.Random.Range(0, 4);

        if ( rnd == 0 )
        {
            RaycastHit2D leftHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.left, 1, groundLayer1);  //上に対象のレイヤーの物があるか確認
            if (leftHit.collider == null)
            {
                Position.x -= SPEED.x; // 代入したPositionに対して加算減算を行う
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90);
            }
        }
        else if ( rnd == 1 )
        {
            RaycastHit2D rightHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.right, 1, groundLayer1);  //上に対象のレイヤーの物があるか確認
            if (rightHit.collider == null)
            {
                Position.x += SPEED.x;
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270);
            }
        }
        else if ( rnd == 2 )
        {
            RaycastHit2D upHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, groundLayer1);  //上に対象のレイヤーの物があるか確認
            if (upHit.collider == null)
            {
                Position.y += SPEED.y;
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
            }
        }
        else if ( rnd == 3 )
        {
            RaycastHit2D downHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.down, 1, groundLayer1);  //上に対象のレイヤーの物があるか確認
            if (downHit.collider == null)
            {
                Position.y -= SPEED.y;
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180);
            }
        }
        transform.position = Position;
    }
}
