using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // This method is now correctly inside the class definition
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            //if the collider of the object whose name is Sonic GameObjects touches the checkpoint's circle collider

            // Assuming LvlMNGR is the correct class name and LvlMNGR is a component in the scene
            FindObjectOfType<LvlMNGR>().CurrentCheckpoint = this.gameObject;
            
            //go to the Level Manager script, and update the value of CurrentCheckpoint to become the new Checkpoint the player has
            //just passed through. This is necessary when you have several checkpoints in a level
        }
    }
}