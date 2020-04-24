using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScaleUltron : MonoBehaviour
{
    // Start is called before the first frame update

    //This program will Scale ultron
    void Start()
    {
        Vector2 newScale = transform.localScale;

        newScale.x /= 2;
        newScale.y /= 2;

        transform.localScale = newScale;
    }


}
