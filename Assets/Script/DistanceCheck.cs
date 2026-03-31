using UnityEngine;


public class DistanceCheck : MonoBehaviour
{
   public Transform playerHead; // XR Camera
    public AudioSource audioSource;
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    public float triggerDistance = 0.2f;

    void Update()
    {
        if (!grabInteractable.isSelected)
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
            return;
        }

        float distance = Vector3.Distance(transform.position, playerHead.position);

        if (distance < triggerDistance)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
                Debug.Log("Play");
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }
}
