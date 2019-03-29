using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject bulletPrefab;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject nb = (GameObject)Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
            nb.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 500);
        }
        

    }
}
