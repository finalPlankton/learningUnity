using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // This will take the reference of the PlayerMovement script.
    // Remember to drag the script in unity editor to make the reference
    public PlayerMovement movement;

    // This method is for detecting the collision between the objects.
    // collisionInfo will have the information about the objects
    // which are collided
    private void OnCollisionEnter(Collision collisionInfo)
    {
        // We can create tags which are group of objects and with that
        // know about collisions of certain tags. If we use name instead
        // of a tag that will become very difficult if the game happens to be
        // very big and if we rename the tag
        if(collisionInfo.collider.tag == "Obstacle")
        {
            // This can be replaced with GetComponent.
            // This allows us to find the component on the object
            // This is used as GetComponent<name_of_the_componet>
            // The below code can be written as
            // GetComponent<PlayerMovement>().enabled = false;
            // This will do the excat same thing
            movement.enabled = false;

            // This unity function will find the type of the Object.
            // Before using this make sure there is one object 
            //of the type searching for otherwise it will throw an error.
            FindObjectOfType<GameManager>().endGame(); 
        }
    }
}
