using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Raycasting : MonoBehaviour
{


    public GameObject Mycube;




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Ray direction
        Vector3 castedRayDirection = Mycube.transform.TransformDirection(Vector3.forward);

        //Store the object that is in front 
        RaycastHit objectInFront;
        //Ray casting
        if (Physics.Raycast(Mycube.transform.position, castedRayDirection, out objectInFront))
        {

            string objectInFrontName = objectInFront.transform.name;
            Debug.Log("There is an object in front of me! It's name is ：" + objectInFrontName);
          

            Destroy(objectInFront.transform.gameObject);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Mycube.transform.Translate(Vector3.left * 0.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Mycube.transform.Translate(Vector3.right * 0.5f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Mycube.transform.Translate(Vector3.up * 0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Mycube.transform.Translate(Vector3.down * 0.5f);
        }
    }


}