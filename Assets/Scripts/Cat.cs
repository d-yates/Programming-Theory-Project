using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{

    public override void Start() {
        base.Start();
        Jump();
    }

    // POLYMORPHISM
    public override void Jump(){
        base.Jump();
        Debug.Log("and is double Jump again.");
    }
}
