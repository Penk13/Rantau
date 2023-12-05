using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Interactable : Collideable
{
    protected bool z_Interacted = false;
    public TextMeshProUGUI interact_text;
    public string target_scene;

    protected override void Start()
    {
        base.Start();
        interact_text.gameObject.SetActive(false);
    }

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
            Debug.Log("INTERACT WITH " + target_scene);
            SceneManager.LoadScene(target_scene);
        }
        else 
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("HEY");
        if (collision.gameObject.name.Equals("Player"))
        {
            interact_text.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            interact_text.gameObject.SetActive(false);
        }
    }
}
