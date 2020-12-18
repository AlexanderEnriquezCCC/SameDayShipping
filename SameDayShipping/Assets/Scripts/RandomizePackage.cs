using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePackage : MonoBehaviour
{
    int PackagesLeft;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PackagesLeftRange()
    {
        PackagesLeft = UnityEngine.Random.Range(1,4);
        Console.WriteLine(PackagesLeft + " packages left");
    }

    void GivePlayerNewPackage()
    {
        
    }
}
