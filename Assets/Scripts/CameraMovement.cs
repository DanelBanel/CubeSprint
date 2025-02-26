using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Reference to the player transform
    [SerializeField] private Transform player;
    // Offset value for the camera position
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -20);



    // Update is called once per frame
    void LateUpdate()
    {
        if (player == null)
            return;
        // Update the camera position based on the player's position and the offset
        transform.position = player.position + offset;
    }
    void OnApplicationQuit()
    {
        Debug.Log("Application ending after " + Time.time + " seconds");
    }

}
