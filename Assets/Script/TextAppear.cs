using UnityEngine;

public class TextAppear : MonoBehaviour
{
    
    public GameObject textObject; // Reference to the text object
    public GameObject contextObject; // Reference to the context object


    //These are public functions so they can be accessed outside the script
    public void hoverEnter()
    {
        Debug.Log("hover entered");
        textObject.SetActive(true); // Show the text object when hovering over the cube
        contextObject.SetActive(true); // Show the context object when hovering over the cube
    }
    

    public void hoverExit()
    {
        Debug.Log("hover exited");
        textObject.SetActive(false); // Hide the text object when not hovering over the cube
        contextObject.SetActive(false); // Hide the context object when not hovering over the cube
    }

    public void selected()
    {
        Debug.Log("selected");
    }
}
