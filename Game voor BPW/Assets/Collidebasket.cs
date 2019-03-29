using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidebasket : MonoBehaviour
{
    public int TotalAmount;
    public int Amount;
    public Animator full;


    private void Update()
    {
        if (Amount == TotalAmount)
        {
            full.SetBool("GaOpen",true);
            
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "KOEGEL")
        {
            print("aaaaaaaa hij doet het");
            Amount += 1;
            
        }
    }

}
