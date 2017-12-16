using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3 : MonoBehaviour
{

    int counter = 0;
    public GameObject cubeReference;
    bool moveLeft = true;
    bool moveRight = false;
    public Material changingcolor;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ///Homework session3 : 1. Create a cube and move it across the screen

        /* this.transform.position =
             new Vector3(transform.position.x+(3*Time.deltaTime), transform.position.y, transform.position.z );*/


        //Homework Session 3: 1. Create a cube and move it across the screen

        /* float speed = 10;
        this.transform.Translate((speed * Time.deltaTime), 0f, 0f, Space.Self);

        float speed2 = 90;
        this.transform.Rotate(0f, 0f, (speed2 * Time.deltaTime), Space.Self);

        float speed3 = 90;
        this.transform.Rotate(new Vector3(1f, 1f, 1f), (speed3 * Time.deltaTime), Space.Self);

        float scale = 5;
        transform.localScale = new Vector3(scale, scale, scale);//?

        */

        //Homework session3 : 2. Create a cube and change its colour when key is pressed or mouse is pressed




        changingcolor.color = Color.black;

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Translate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.Y))
        {
            changingcolor.color = Color.yellow;
        }

        if (Input.GetMouseButton(0))
        {
            changingcolor.color = Color.red;
        }

        if (Input.GetMouseButtonDown(2))
        {
            gameObject.transform.localScale = new Vector3 (0.5f, 0.5f,0.5f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            gameObject.transform.localScale = new Vector3(1f, 2f, 3f);
        }


    }
}

    //private void Movetowardstarget(Vector3 targetposition)
    //{
    //    float speed4 = 1;
    //    Vector3 currentposition = this.transform.position;

    //    if (Vector3.Distance(currentposition, targetposition) > 1)
    //    {
    //        Vector3 directionoftravel = targetposition - currentposition;
    //        directionoftravel.Normalize();
    //        this.transform.Translate(
    //            (directionoftravel.x * speed4 * Time.deltaTime), 
    //            (directionoftravel.y * speed4 * Time.deltaTime), 
    //            (directionoftravel.z * speed4 * Time.deltaTime),
    //            Space.World);
    //    }
    //    }



