using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject _Mainmenu ,_GamePlay, _CreditsMenu, _HelpMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnButtonClick(GameObject _UIObject)
    {
        if (_UIObject.name == "Start")
        {
            _Mainmenu.SetActive(false);
            _GamePlay.SetActive(true);
        }
        if (_UIObject.name == "Credits")
        {
            _Mainmenu.SetActive(false);
            _CreditsMenu.SetActive(true);
        }
        if (_UIObject.name == "help")
        {
            _Mainmenu.SetActive(false);
            _HelpMenu.SetActive(true);
        }
        if (_UIObject.name == "Exit")
        {
            Application.Quit();
        }
        if (_UIObject.name == "Back")
        {
            _CreditsMenu.SetActive(false);
            _HelpMenu.SetActive(false);
            _Mainmenu.SetActive(true);
        }
        if (_UIObject.name == "Home")
        {

            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;
        }

    }

}
