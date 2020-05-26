using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Get reference to Transform component to player
    // This gives information about player's
    // position, rotation and scale
    public Transform player;
    
    //A Vector3 stores 3 float numbers.
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        // This transform is for the object this script is
        // currently sitting on here it is the MainCamera
        transform.position = player.position + offset; 
    }
}
