using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update

    public string typeAnimal;

    public virtual void Start() {
        Debug.Log("A new animal is created : " + typeAnimal);
    }

     // POLYMORPHISM
    public virtual void Jump(float maxHeight){
        Debug.Log("The " + typeAnimal + " it's jumping at a height of : " + maxHeight);
    }

    public virtual void Jump(Vector3 jumpForce){
        Debug.Log("The " + typeAnimal + " it's jumping at a force of : " + jumpForce);
    }

    public void Move(){
        Debug.Log("The " + typeAnimal + " is move forward");
    }

    public void Eat(){
        Debug.Log("The " + typeAnimal + " eats");
    }
}
