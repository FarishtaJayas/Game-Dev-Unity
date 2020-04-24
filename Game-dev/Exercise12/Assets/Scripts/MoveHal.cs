using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This program will make Hal move
/// </summary>

public class MoveHal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(4, 0),
            ForceMode2D.Impulse);

    }

    //Collision code
    //This is collision resolution where we print ouch everytime the character hits something

    void OnCollisionEnter2D(Collision2D coll)
    {

        print("Ouch");

    }


}
