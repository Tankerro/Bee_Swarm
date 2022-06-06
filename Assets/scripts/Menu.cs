using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public Text pollenText;
    public GameObject menu;
    public GameObject Hive;
    public GameObject Shop;

    void Update()
    {
        
    }

    public void PollenSetup(int pollen)
    {
        pollenText.text = pollen.ToString();
    }

    public void hive()
    {
        menu.SetActive(false);
        Hive.SetActive(true);

    }

    public void shop()
    {
        menu.SetActive(false);
        Shop.SetActive(true);
    }

    public void exit()
    {
        Hive.SetActive(false);
        Shop.SetActive(false);
        menu.SetActive(true);
    }
}
