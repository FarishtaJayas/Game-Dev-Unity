using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateTemperature : MonoBehaviour
{
    /// <summary>
    /// We see how data type really matters in this program
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        //int
        int tempIntFahrenheit;
        int tempIntCelcius;
        int tempIntCelciusToFahrenheit;

        tempIntFahrenheit = 0;
        print("Fahrenheit: " + tempIntFahrenheit);

        tempIntCelcius = 5 * ((tempIntFahrenheit - 32) / 9);
        print("Celsius: " + tempIntCelcius);

        tempIntCelciusToFahrenheit = ((9 * tempIntCelcius) / 5) + 32;
        print("Celsius to Fahrenheit: " + tempIntCelciusToFahrenheit);

        //float
        float tempFloatFahrenheit;
        float tempFloatCelcius;
        float tempFloatCelciusToFahrenheit;

         

        tempFloatFahrenheit = 0;
        print("Fahrenheit " + tempFloatFahrenheit);

        tempFloatCelcius = 5 * ((tempFloatFahrenheit - 32) / 9);
        print("Celsius: " + tempFloatCelcius);

        tempFloatCelciusToFahrenheit = ((9 * tempFloatCelcius) / 5) + 32;
        print("Celsius to Fahrenheit: " + tempFloatCelciusToFahrenheit);

        //Double
        double tempDoubleFahrenheit;
        double tempDoubleCelcius;
        double tempDoubleCelciusToFahrenheit;



        tempDoubleFahrenheit = 0;
        print("Fahrenheit" + tempDoubleFahrenheit);

        tempDoubleCelcius =  5 * ((tempDoubleFahrenheit - 32) / 9);
        print("Celsius: " + tempDoubleCelcius);

        tempDoubleCelciusToFahrenheit = ((9 * tempDoubleCelcius) / 5) + 32;
        print("Celsius to Fahrenheit: " + tempDoubleCelciusToFahrenheit);
    }

   
}
