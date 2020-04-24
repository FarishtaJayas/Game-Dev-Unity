using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this program will make the main character 2 times as large
/// </summary>

public class MainCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;

        //2times as large

        newScale.x *= 2;
        newScale.y *= 2;

        transform.localScale = newScale;
        
    }

    
}
