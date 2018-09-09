using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void TestingMap() {
        SceneManager.LoadScene("TestingMap");
    }

    public void Level01() {
        SceneManager.LoadScene("Level01");
    }

    public void QuitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
