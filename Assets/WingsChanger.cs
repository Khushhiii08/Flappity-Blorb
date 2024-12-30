using UnityEngine;

public class WingsChanger : MonoBehaviour
{
    public BlorbScript b;
    public GameObject wings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && b.blorbIsAlive)
        {
            FlipVertically(wings);

        }

        if (Input.GetKeyUp(KeyCode.Space) && b.blorbIsAlive)
        {
            FlipVertically(wings);
        }
    }

    public void FlipVertically(GameObject wings)
    {
        // Flip the Y-axis of the object's local scale
        Vector3 scale = wings.transform.localScale;
        scale.y = -scale.y;  // Invert the Y-axis (vertical flip)
        wings.transform.localScale = scale; // Apply the modified scale back to the object
    }

}
