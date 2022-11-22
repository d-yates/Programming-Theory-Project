using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    public override void Start() {
        nameAnimal = "Smoky";
        base.Start();
        Jump(5);
    }

    // POLYMORPHISM
    public override void Jump(float maxHeight){
        base.Jump(maxHeight);
        Debug.Log("and is double Jump again.");
    }
}
