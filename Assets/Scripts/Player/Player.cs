using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI moneyText;
    private int money = 0;

    public AudioSource audioSource;
    private float volume;

    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        moneyText.text = "Money: " + money.ToString();

        PlayerPrefs.SetFloat("MusicVolume", 0.5f);
        volume = PlayerPrefs.GetFloat("MusicVolume");
        audioSource.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void AddMoney(int amount)
    {
        money += amount;
        moneyText.text = "Money: " + money.ToString();

        // You may also save the updated money value to PlayerPrefs or another persistent storage if needed
        PlayerPrefs.SetInt("Money", money);
    }
}
