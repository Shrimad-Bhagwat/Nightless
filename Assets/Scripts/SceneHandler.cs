using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneHandler: MonoBehaviour {  

    public void PlayGame() {  
        SceneManager.LoadScene("Story1");  
    }  
    public void Credits() {  
        SceneManager.LoadScene("Credits");  
    }  
    public void Menu() {  
        SceneManager.LoadScene("MENU");  
    }  
    public void Exit() {  
        Application.Quit();
        Debug.Log("Exit");
    }  
}   