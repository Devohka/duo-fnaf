using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;

    [SerializeField] GameObject continuePanel;
    [SerializeField] GameObject settingPanel;
    bool isShowSetting = true;
    bool isShowContinue = true;
    // Start is called before the first frame update

    public void showSetting()
    {
        isShowSetting = !isShowSetting;
        menuPanel.SetActive(isShowSetting);
        settingPanel.SetActive(!isShowSetting);
    }

     public void showContinue()
    {
        isShowContinue = !isShowContinue;
        menuPanel.SetActive(isShowContinue);
        continuePanel.SetActive(!isShowContinue);
    }


    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
