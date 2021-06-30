using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    // ���x
    public Vector2 SPEED = new Vector2(1.0f, 1.0f);

    // ColliderCheck
    public GameObject pl;
    public LayerMask groundLayer1;
    public LayerMask EnemyLayer;
    public LayerMask DoorLayer;
    public LayerMask KeyLayer;




    void Start()
    { }


    void Update()
    {
        // Move();
        //wall_Check();
    }
    public void Move()
    {
        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;   //�S�̂��猩����]���擾

        worldAngle.z = (float)Math.Round(worldAngle.z, 1, MidpointRounding.AwayFromZero);

        Vector2 Position = transform.position;  // ���݈ʒu��Position�ɑ��

        if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))   //z = 90
        {
            RaycastHit2D leftHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.left, 1, groundLayer1);  //��ɑΏۂ̃��C���[�̕������邩�m�F
            if (leftHit.collider == null)
            {
                Position.x -= SPEED.x; // �������Position�ɑ΂��ĉ��Z���Z���s��
            }
            else { }

            if (worldAngle.z == 0.0f) { myTransform.Rotate(new Vector3(0, 0, 90.0f)); }
            else if (worldAngle.z == 180.0f) { myTransform.Rotate(new Vector3(0, 0, -90.0f)); }
            else if (worldAngle.z == 270.0f) { myTransform.Rotate(new Vector3(0, 0, -180.0f)); }
            else { }

        }
        else if (Input.GetKeyDown("right") || Input.GetKeyDown("d")) //z = 270
        {
            RaycastHit2D rightHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.right, 1, groundLayer1);  //��ɑΏۂ̃��C���[�̕������邩�m�F
            if (rightHit.collider == null)
            {
                Position.x += SPEED.x;
            }
            else { }
            if (worldAngle.z == 0.0f) { myTransform.Rotate(new Vector3(0, 0, 270.0f)); }
            else if (worldAngle.z == 90.0f) { myTransform.Rotate(new Vector3(0, 0, 180.0f)); }
            else if (worldAngle.z == 180.0f) { myTransform.Rotate(new Vector3(0, 0, 90.0f)); }
            else { }

        }
        else if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))    //z = 0
        {
            RaycastHit2D upHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, groundLayer1);  //��ɑΏۂ̃��C���[�̕������邩�m�F
            if (upHit.collider == null)
            {
                Position.y += SPEED.y;
            }
            else { }
            if (worldAngle.z == 90.0f) { myTransform.Rotate(new Vector3(0, 0, -90.0f)); }
            else if (worldAngle.z == 180.0f) { myTransform.Rotate(new Vector3(0, 0, -180.0f)); }
            else if (worldAngle.z == 270.0f) { myTransform.Rotate(new Vector3(0, 0, -270.0f)); }
            else { }

        }
        else if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))  //z = 180
        {
            RaycastHit2D downHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.down, 1, groundLayer1);  //��ɑΏۂ̃��C���[�̕������邩�m�F
            if (downHit.collider == null)
            {
                Position.y -= SPEED.y;
            }
            else { }
            if (worldAngle.z == 0.0f) { myTransform.Rotate(new Vector3(0, 0, 180.0f)); }
            else if (worldAngle.z == 90.0f) { myTransform.Rotate(new Vector3(0, 0, 90.0f)); }
            else if (worldAngle.z == 270.0f) { myTransform.Rotate(new Vector3(0, 0, -90.0f)); }
            else { }

        }
        // ���݂̈ʒu�ɉ��Z���Z���s����Position��������
        transform.position = Position;


    }
/*
    public void Action()
    {
        
        if (Input.GetKeyDown("space"))
        {
            RaycastHit2D upHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.up, 1, DoorLayer);
            RaycastHit2D downHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.down, 1, DoorLayer);
            RaycastHit2D rightHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.right, 1, DoorLayer);
            RaycastHit2D leftHit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0, Vector2.left, 1, DoorLayer);
            //  ���̂Ȃ��h�A
            if (upHit.collider != null || downHit.collider != null || rightHit.collider != null || leftHit.collider != null)
            {
                
            }
        }
    }
*/
}
