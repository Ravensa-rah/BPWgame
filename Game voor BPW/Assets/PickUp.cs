using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdbox : MonoBehaviour
{
    public GameObject item;
    public GameObject tempParent;
    public Transform Guide;

    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = Guide.transform.position;
            item.transform.rotation = Guide.transform.rotation;
            item.transform.parent = tempParent.transform;

        }
    }
    void OnMouseExit()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = Guide.transform.position;
        }


    }


}
