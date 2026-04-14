using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public Animator doorAnimator; // Reference to the Animator component of the door
 
    public void OpenDoor()
    {
        doorAnimator.SetTrigger("Open");
    }

}
