using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour
{
    private Enemy moveEnemy;

    void Start()
    {
        moveEnemy = GetComponentInParent<Enemy>();
    }

    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player")
        { Debug.Log("Œ©‚Â‚¯‚½"); }
    }
}
