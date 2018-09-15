using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour {



    private void OnCollisionEnter2D(Collision2D collision) {
        GameObject.Find("Player").GetComponent<PlayerHealth>().PlayerHealthReduction(1);
        SceneManager.LoadScene("Level01");
        GameObject.Find("Player").GetComponent<PlayerHealth>().PlayerhealthCheck();
       
    }

}

