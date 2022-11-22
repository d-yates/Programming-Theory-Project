using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    public override void Start() {
        base.Start();
        Jump();
    }

}
