using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshPro uiText;
    public string typeAnimal;

    // Encapsulation
    private string m_NameAnimal;

    public string nameAnimal
    {
        get { return m_NameAnimal; }
        set
        {
            if (value.Length > 10)
            {
                Debug.LogError("The name is to long");
            }
            else
            {
                m_NameAnimal = value;
            }
        }
    }


    public virtual void Start()
    {
        Debug.Log("A new " + typeAnimal +  " is created and name is : " + nameAnimal);
        uiText.text = typeAnimal + "\n" + nameAnimal;
    }

    // POLYMORPHISM
    public virtual void Jump(float maxHeight)
    {
        Debug.Log("The " + typeAnimal + " it's jumping at a height of : " + maxHeight);
    }

    public virtual void Jump(Vector3 jumpForce)
    {
        Debug.Log("The " + typeAnimal + " it's jumping at a force of : " + jumpForce);
    }

    // Abstraction 
    public void Move()
    {
        Debug.Log("The " + typeAnimal + " is move forward");
    }

    // Abstraction 
    public void Eat()
    {
        Debug.Log("The " + typeAnimal + " eats");
    }
}
