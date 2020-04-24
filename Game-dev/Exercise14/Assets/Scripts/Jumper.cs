using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
///This program will make infector Jump
///</summary>
public class Jumper : MonoBehaviour
{
    // Start is called before the first frame update

    //jump location support
    const float minX = -5;
    const float maxX = 5;

    const float minY = -1.8f;
    const float maxY = 1.8f;

    //timer support
    const float TotalJumpsDelaySeconds = 0.005f;
    float elapsedJumpDelaySeconds = 0;

    ///<summary>
    ///update is called once per frame
    ///</summary>
    void Update()
    {
        //update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if (elapsedJumpDelaySeconds >= TotalJumpsDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            transform.position = new Vector3(
                Random.Range(minX, maxX),
                Random.Range(minY, maxY),
                0);


        }

    }


}
