using UnityEngine;

public class QuitApp : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the user presses the "E" key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Quit App
            Application.Quit(); 
        }
    }
}
