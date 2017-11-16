//References
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//where code lives
public class Session1 : MonoBehaviour {


    //Variables
    //Scope--Type--Name--Value

    //Homework:1. Delcare a int variable and set a value
   public int myage = 23;
    //Homework:2. Delcare a float variable and set a value
   public float myheight = 1.78f;

    //Homework:3. Delcare a string variable and set a value
    public string myname = "Jialin Zhang";

    /*Logical variable
    bool IamMale = true;(not use in this homework script)*/

    

    //Homework:5.Declare and initialize an array
    public string[] clustername = new string[8];


    //Homework:6.Declare and initialize a List
    List<string> weapon = new List<string>() { "machinegun", "shotgun", "sword" };
    public List<int> number = new List<int>();

    //Homework:6.Declare and initialize a Dictionary
    Dictionary<int, string> groupmember = new Dictionary<int, string>();




    // Use this for initialization
    void Start()
    {
        //Homework:4. Create a function that prints the declared variables

        print("hello UK");

        myname = "update during start()";

        Debug.Log("Addition of myage and 3 is :" + AdditionOfNumbers(myage, 3));

        clustername[4] = "RC3";

        Debug.Log("our research cluster is:" + clustername[4]);

        Debug.Log("total number of Research Cluster:" + clustername.Length);

        number.Add(1);
        number.Add(2);
        number.Add(3);

        weapon.Add("stick");
        weapon.Add("Knife");

        Debug.Log("Total weapons:" + weapon.Count);
        Debug.Log("First Weapon:" + weapon[0]);
        Debug.Log("Last Weapon:" + weapon[weapon.Count-1]);


        groupmember.Add(1, "Peljevic, Jelena");
        groupmember.Add(2, "Abolghasem Tehrani, Yekta");
        groupmember.Add(3, "Chen, Chun-Yen");
        groupmember.Add(4, "Al Chawa, Mohamad");
        groupmember.Add(5, "Alkhaja, Nour");
        groupmember.Add(6, "Cao, Linlin");
        groupmember.Add(7, "Zhang, Danyang");

        Debug.Log("First Group Number is:" + groupmember[1]);
        Debug.Log("is there a 4th groupmember in our group? Answer:" + groupmember.ContainsKey(4));
        Debug.Log("is there a 8th groupmember in our group? Answer:" + groupmember.ContainsKey(8));

    }

    



    // Update is called once per frame
    void Update(){
        Debug.Log("I am 26 years old now");
    }

    int AdditionOfNumbers(int number1, int number2)
    {
        int additionResult = number1 + number2;
        return additionResult;
    }

}
