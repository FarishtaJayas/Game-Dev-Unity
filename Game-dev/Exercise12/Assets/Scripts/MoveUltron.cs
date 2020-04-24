using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUltron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This code will move ultron

        const float MinImpulseForce = 4f;
        const float MaxImpulseForce = 8f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 directions = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));

        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            directions * magnitude,
            ForceMode2D.Impulse);



    }


}
