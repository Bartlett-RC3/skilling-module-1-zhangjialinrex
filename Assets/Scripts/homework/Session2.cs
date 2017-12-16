using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour
{

    public string NBAplayer = "Kobe Bryant";
    string[] actor = new string[8];
    List<Dog> Mydog = new List<Dog>();
    //List to sture dog

    // Use this for initialization
    void Start()
    {
        
        Condition();
        Looptest();
    }


 
    void Condition()
    {   //Session Homework 2:1. Write Function use a Condition

        /*  string NBAplayer = "Kobe Bryant";

          if (NBAplayer == "Kobe Bryant")
          {
              Debug.Log("NBA MVP is:" + NBAplayer);
          }
          else
          {
              Debug.Log("All other players are not MVP");
          }*/

        //more practice about else if
       

        if (NBAplayer == "Lebron James")
        {
            Debug.Log("NBA MVP is:" + NBAplayer);
        }
        else if (NBAplayer == "Kobe Bryant")
        {
            Debug.Log("NBA MVP is:" + NBAplayer);
        }
        else
        {
            Debug.Log("NBA MVP is not:" + NBAplayer);
        }

        //MORE practice 


        int killer = 4;

        /*if (Killer > 3)
         {
             Debug.Log("King is dead");
         }else if (Killer <= 3)
         {
             Debug.Log("king is alive");
         }*/

        killer = 4;
        bool kingisdead = killer > 3;

        Debug.Log("king is dead?" + kingisdead);

        if (kingisdead)

            Debug.Log("King is dead");

        string Prince = kingisdead == true ? " will be the new King" : " is still Prince";
        Debug.Log("Prince" + Prince);

    }


    //Session Homework 2:1. Write a for loop
    void Looptest()
    {
        actor[1] = "Jack Chen";
        actor[2] = "Bruce Lee";
        

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Lakers" + i);
        }

        for (int i = 10; i >0; i--)
        {
            Debug.Log("Lakers" + i);
        }

        for (int i=0; i<actor.Length;i++)
        {
            Debug.Log("actor " + i + " " +actor[i]);
        }

        List<int> year = new List<int>();
        for (int i = 0; i<364; i++)
        {
            year.Add(i);
        }

        for (int i = 0; i < year.Count; i = i + 5) 
        {
            Debug.Log("year divisable by 5: " + year[i]);
        }


        //Write a dog class and initialize an instance of the class

       Dog Dorri = new Dog(11, 0.2f, false, "Dorri");
        Dog Tony = new Dog(2, 0.4f, true, "Tony");
        Dog Lynda = new Dog(3, 0.1f, false, "Lynda");

        Mydog.Add(Dorri);
        Mydog.Add(Tony);
        Mydog.Add(Lynda);


    }


    // Session2 Homework: 3 Update is called once per frame
    void Update()
    {for (int i = 0; i < Mydog.Count; i++)
        {
            Debug.Log(Mydog[i].Getname());
          
        }

    }

}
