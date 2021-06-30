using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixEnemy : MonoBehaviour
{
    public Vector2 SPEED = new Vector2(1.0f, 1.0f);
    private int x;
    void Start()
    {
        x = 0;
    }

    public void fixEnemyMove()
    {
        Vector2 Position = transform.position;

        {
            // ‰E
            if (x < 16)
            {
                Position.x += SPEED.x;
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
            }
            //‰º
            else if (16 <= x && x < 32)
            {
                Position.y -= SPEED.y;
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270);
            }
            //ã
            else if (32 <= x && x < 48)
            {
                Position.y += SPEED.y;
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90);
            }
            //¶
            else if (48 <= x && x < 64)
            {
                Position.x -= SPEED.x;
                transform.position = Position;
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180);

            }
            else
            {
                x = -1;
            }
            transform.position = Position;
            x++;
        }
    }
}
