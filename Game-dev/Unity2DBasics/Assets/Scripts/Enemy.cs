using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This program will make the enemy 2 times as large
/// </summary>

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;

        //2times as big

        newScale.x *= 2;
        newScale.y *= 2;

        transform.localScale = newScale;
    }
}
