using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : Collideable
{
    protected bool z_Interacted = false;
    protected override void OnCollided(GameObject collidedObject) {
        if (Input.GetKey(KeyCode.E))
        {
            OnInteract();
        }
    }

    protected virtual void OnInteract(){
        if (!z_Interacted)
        {
            z_Interacted = true;
            Debug.Log("INTERACT WITH " + name);
            SceneManager.LoadScene(name);
        }
        else 
        {

        }
    }
}
