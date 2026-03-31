using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    
    public GameObject textObject; // Reference to the text object


    //These are public functions so they can be accessed outside the script
    public void hoverEnter()
    {
        Debug.Log("hover entered");
        textObject.SetActive(true); // Show the text object when hovering over the cube
    }
    

    public void hoverExit()
    {
        Debug.Log("hover exited");
        textObject.SetActive(false); // Hide the text object when not hovering over the cube
    }

    public void selected()
    {
        Debug.Log("selected");
    }
}
