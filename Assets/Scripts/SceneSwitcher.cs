using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToLvlSelect()
    {
        SceneManager.LoadScene("Lvl Select");
    }

    public void SelectLvl1()
    {
        SceneManager.LoadScene("Lvl 1");
    }

    public void SelectLvl2()
    {
        SceneManager.LoadScene("Lvl 2");
    }

    public void SelectLvl3()
    {
        SceneManager.LoadScene("Lvl 3");
    }

    public void SelectLvl4()
    {
        SceneManager.LoadScene("Lvl 4");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
