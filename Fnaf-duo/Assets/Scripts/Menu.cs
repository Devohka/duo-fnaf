using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;

    [SerializeField] GameObject settingPanel;
    bool isShowSetting = true;
    // Start is called before the first frame update

    public void showSetting()
    {
        isShowSetting = !isShowSetting;
        menuPanel.SetActive(isShowSetting);
        settingPanel.SetActive(!isShowSetting);
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
