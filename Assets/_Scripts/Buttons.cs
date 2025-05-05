using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
 

    public GameObject creditsmenu;
    public GameObject instructionsmenu;
    public GameObject Levelmenu;
    public GameObject MenuMenu;

    public static void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1.0f;

    }
    public static void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
        Time.timeScale = 1.0f;

    }
    public static void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
        Time.timeScale = 1.0f;

    }
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1.0f;

    }
    public static void LoadWinScreen()
    {
        SceneManager.LoadScene("End_Screne");
        Time.timeScale = 1.0f;

    }
    public static void LoadLossScreen()
    {
        SceneManager.LoadScene("Loss_Screne");
        Time.timeScale = 1.0f;
    }
    public static void Quitbutton()
    {
        Application.Quit();

    }
    public void Instructions()
    {
        instructionsmenu.SetActive(true);
        MenuMenu.SetActive(false);

    }
    public void credits()
    {
        creditsmenu.SetActive(true);
        MenuMenu.SetActive(false);

    }
    public void levelmenu()
    {
        Levelmenu.SetActive(true);
        MenuMenu.SetActive(false);
    }











}
