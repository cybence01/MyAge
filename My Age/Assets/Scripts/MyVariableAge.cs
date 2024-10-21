using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVariableAge : MonoBehaviour
{
public int currentAge = 22; //This integer is my current age
public int ageIncrease = 1; //This integer is the added value to my current age



    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("My age right now is: currentAge = {0}", currentAge); //This Debug.Log will display my current age
        
        int ageNextYear = currentAge + ageIncrease; //This integer adds the values of currentAge and ageIncrease, to show my age next year
        
        Debug.LogFormat("My age next year will be: ageNextYear = {0}", ageNextYear); //This Debug.Log will display my age next year
        
        int ageIncreaseMore = 5; 
        int ageIncreaseEvenMore = 12;

        int ageInFiveYears = currentAge + ageIncreaseMore; //This integer adds the value of my currentAge and ageIncreaseMore to showcase my age in five years 
        int ageInTwelveYears = currentAge + ageIncreaseEvenMore; //This integer adds the value of my currentAge and ageIncreaseEvenMore to showcase my age in twelve years

        Debug.LogFormat("My age in five years will be: ageInFiveYears = {0} and in twelve years it will be ageInTwelveYears = {1}", ageInFiveYears, ageInTwelveYears);
        //The Debug.Log over this comment will display my age in five years and in twelve years


        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
