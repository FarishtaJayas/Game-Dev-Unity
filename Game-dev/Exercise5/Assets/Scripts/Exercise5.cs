using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    /// <summary>
    /// We will declare using constants and variables
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        const int MaxScore = 100;
        int score = 69;

        //finding %

        float percent = ((float)score / MaxScore) * 100;

        print("The % is =" + percent + "%");




    }

}
