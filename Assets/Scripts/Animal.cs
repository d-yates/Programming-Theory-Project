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

    public virtual void Jump(){
        Debug.Log("The " + typeAnimal + " is jump");
    }

    public void Move(){
        Debug.Log("The " + typeAnimal + " is move forward");
    }

    public void Eat(){
        Debug.Log("The " + typeAnimal + " eats");
    }
}
