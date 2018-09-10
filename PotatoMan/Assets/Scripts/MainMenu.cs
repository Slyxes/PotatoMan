using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [SerializeField] private string Level01Music;


    public void TestingMap() {
        SceneManager.LoadScene("TestingMap");
    }

    public void Level01() {
        SceneManager.LoadScene("Level01");
        FMODUnity.RuntimeManager.PlayOneShot(Level01Music);
    }

    public void QuitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
