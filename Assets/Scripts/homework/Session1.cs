//References
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//where code lives
public class Session1 : MonoBehaviour {


    //1.Variables
    //Scope--Type--Name--Value

    //Numbers
    public int myFirstIntegerNumber = 98;
    public float myFirstFloatNumber = 1.78f;

    //Text
    public string myFirstString = "My text is here.";

    //Logical variable
    bool myFirstBoolean = true;

    //Data Structures
    //scope--type--Values


    //3. a.Arrays
    public int[] myIntegrerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatingArray = new float[5];

    //3. b.Lists
    public List<int> myIntegerList = new List<int>();

    //2.Functions
    //scope--type--Variables--Body(Instructions)


    // Use this for initialization
    void Start()
    {
        Debug.Log("Addition of 5 and 3 is :" + AdditionOfNumbers(5, 3));
        myFloatingArray[2] = 3.2f;
        myFloatingArray[3] = 5.6f;
        myFloatingArray[4] = 9.2f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);

    }

    



    // Update is called once per frame
    void Update(){
        Debug.Log("Hello world!");
    }

    int AdditionOfNumbers(int number1, int number2)
    {
        int additionResult = number1 + number2;
        return additionResult;
    }

}
