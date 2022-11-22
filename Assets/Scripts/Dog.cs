using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    private int forceJump = 2;
    public override void Start() {
        base.Start();
        Jump(Vector3.up * forceJump);
    }

}
