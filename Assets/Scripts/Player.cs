using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI moneyText;
    private int money = 0;
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        moneyText.text = "Money: " + money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
