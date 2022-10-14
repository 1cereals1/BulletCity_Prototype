using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    public static int numberofcoins;
    public TextMeshProUGUI coinsText;

    public GameObject[] playerPrefabs;
    int weaponIndex;

    
    private void Awake()
    {
        weaponIndex = PlayerPrefs.GetInt("SelectedWeapon", 0);
        GameObject player = Instantiate(playerPrefabs[weaponIndex]);
        isGameOver = false;
        numberofcoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        coinsText.text = " " + numberofcoins;
    }
}
