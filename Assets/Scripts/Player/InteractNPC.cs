using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class InteractNPC : Collideable
{
    protected bool z_Interacted = false;
    public TextMeshProUGUI interact_text;
    public TextMeshProUGUI dialog;

    protected override void Start()
    {
        base.Start();
        interact_text.gameObject.SetActive(false);
        dialog.gameObject.SetActive(false);
    }

    protected override void OnCollided(GameObject collidedObject) {
        if (Input.GetKey(KeyCode.E))
        {
            if (collidedObject.tag == "Player")
            {
                OnInteract();
            }
        }
    }

    protected virtual void OnInteract(){
        if (!z_Interacted)
        {
            z_Interacted = true;
            dialog.gameObject.SetActive(true);
        }
        else 
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
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
            dialog.gameObject.SetActive(false);
            z_Interacted = false;
        }
    }
}
