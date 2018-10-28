using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoadNUnload : MonoBehaviour {

    //LoL du ded
    public void YouLostNoob() {
        SceneManager.UnloadSceneAsync("Level01");
        PlayerHealth.Playerhealth = 100;
        SceneManager.LoadScene("MainMenu");
        FMODUnity.RuntimeManager.Destroy();
    }
    //You wanna go to mainmenu Ok.
    public void GoToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
    public void TestingMap() {
        SceneManager.LoadScene("TestingMap");
    }
    public void Level01() {
        SceneManager.LoadScene("Level01");
        //FMODUnity.RuntimeManager.PlayOneShot();
    }   
    public void QuitGame() {
        Application.Quit();
    }
}
