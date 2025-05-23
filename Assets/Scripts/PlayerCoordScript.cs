using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCoordScript : MonoBehaviour
{
    public GameObject worldObject; // Assign your 3D object in the Inspector
    [SerializeField] TextMeshProUGUI coordinateDisplay; // Assign the Text object to display the coordinates

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the world position
        Vector3 worldPosition = worldObject.transform.position;

        // Convert to a string for display
        string coordinates = $"X: {worldPosition.x}, Y: {worldPosition.y}, Z: {worldPosition.z}";

        // Update the Text object
        coordinateDisplay.text = coordinates;
    }
}
