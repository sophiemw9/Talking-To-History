using UnityEngine;


public class SnapToEar : MonoBehaviour
{
    public Transform earAnchor;
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab;

    public float snapDistance = 0.25f;
    public float snapSpeed = 10f;

    private bool isSnapped = false;

    void Update()
    {
        if (!grab.isSelected)
        {
            isSnapped = false;
            return;
        }

        float distance = Vector3.Distance(transform.position, earAnchor.position);

        if (distance < snapDistance)
        {
            isSnapped = true;
            Debug.Log("Snap");
        }

        if (isSnapped)
        {
            // Smooth snap position
            transform.position = Vector3.Lerp(
                transform.position,
                earAnchor.position,
                Time.deltaTime * snapSpeed
            );

            // Smooth snap rotation
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                earAnchor.rotation,
                Time.deltaTime * snapSpeed
            );
        }
    }
}