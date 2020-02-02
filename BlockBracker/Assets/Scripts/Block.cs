using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); // destroying the game object
        Debug.Log(collision.gameObject.name); // prints the name of the object that has been colided with the gameobject
    }

}
