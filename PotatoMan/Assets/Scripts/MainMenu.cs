using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour {

    public GameLoadNUnload GameLoadNUnload;

    public void TestingMap() {
        GameLoadNUnload.TestingMap();
    }

    public void Level01() {
        GameLoadNUnload.Level01();
    }

    public void QuitGame() {
        GameLoadNUnload.QuitGame();
    }

}
