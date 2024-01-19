using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class EndingInteract: Collideable
{
    protected bool z_Interacted = false;
    public TextMeshProUGUI interact_text;
    public TextMeshProUGUI not_enough_money;
    public TextMeshProUGUI dialog;

    private int money = 0;
    protected override void Start()
    {
        base.Start();
        interact_text.gameObject.SetActive(false);
        dialog.gameObject.SetActive(false);
        not_enough_money.gameObject.SetActive(false);   
    }
    
    protected override void OnCollided(GameObject collidedObject)
    {
        money = PlayerPrefs.GetInt("Money");
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collidedObject.tag == "Player" && money>=200)
            {
                PlayerPrefs.SetInt("Money", money - 200);
                SceneManager.LoadScene("EndOfChapter");
            }
            else if (collidedObject.tag == "Player" && money < 200)
            {
                not_enough_money.gameObject.SetActive(true);
            }
        }
    }

    protected virtual void OnInteract()
    {
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
            not_enough_money.gameObject.SetActive(false); ;
            z_Interacted = false;
        }
    }
}
