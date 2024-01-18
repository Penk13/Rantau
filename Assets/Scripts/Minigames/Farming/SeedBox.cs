using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class SeedBox : Collideable
{
    protected bool z_Interacted = false;
    public TextMeshProUGUI interact_text;
    public GameObject seed;

    protected override void Start()
    {
        base.Start();
        interact_text.gameObject.SetActive(false);
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

            Vector3 centerPosition = transform.position;
            centerPosition.z = -3f;
            Instantiate(seed, centerPosition, Quaternion.identity, transform);
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
            if (transform.childCount <= 1)
            {
                z_Interacted = false;
            }
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
