using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleHal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 newScale = transform.localScale;

        newScale.x /= 2;
        newScale.y /= 2;

        transform.localScale = newScale;
        
    }
}
