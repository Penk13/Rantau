using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the user presses the "E" key
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Load the scene named "Main"
            SceneManager.LoadScene("Main");
        }
    }
}
