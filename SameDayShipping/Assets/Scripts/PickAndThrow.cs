using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PickAndThrow : MonoBehaviour
{
    float throwForce = 500;
    Vector3 objPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;


    // Update is called once per frame
    void Update()
    {
        //check holding
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if (Input.GetMouseButtonDown(1))
            {
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                isHolding = false;
            }
        }
        else
        {
            objPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objPos;
        }
    }

    void OnMouseDown()
    {
        isHolding = true;
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().detectCollisions = true;
    }

    void OnMouseUp()
    {
        isHolding = false;
    }
}
