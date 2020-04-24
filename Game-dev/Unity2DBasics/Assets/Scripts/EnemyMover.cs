using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This program wil move the enemy
/// </summary>

public class EnemyMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(2,10),
            ForceMode2D.Impulse
            );
    }

   
}
