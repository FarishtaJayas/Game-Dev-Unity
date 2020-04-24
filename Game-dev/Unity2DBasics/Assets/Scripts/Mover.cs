using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the game object
/// </summary>
public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //get the game object moving

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();  //generic method is done this way
        rb2d.AddForce(new Vector2(10,2), 
        ForceMode2D.Impulse) ;
        
    }

    
}
