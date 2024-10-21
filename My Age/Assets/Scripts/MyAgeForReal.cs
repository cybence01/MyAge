using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAgeForReal : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentAge = 22; //This int is my current age 
    public int ageIncrease = 1; //This int is the value added to my age next year
    string myName = "Viktor"; //This string is my first name
    private int ageIncreaseMore = 5;
    private int ageIncreaseEvenMore = 12;

    void Start()
    {
        Debug.LogFormat("Hello, my name is, {0} - I am {1} years old.", myName, currentAge);
        int ageNextYear = currentAge + ageIncrease; //This line adds the values together. 
        Debug.LogFormat("Next year I will be {0}", ageNextYear);

        Debug.LogFormat("In {0} years, I will be {1} and in {2} years, I will be {3}.", 
        ageIncreaseMore, IncreaseAge(currentAge, ageIncreaseMore), ageIncreaseEvenMore, IncreaseAge(currentAge, ageIncreaseEvenMore));
        

    }

    int IncreaseAge(int a, int b)
    {
        return (a+b); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
