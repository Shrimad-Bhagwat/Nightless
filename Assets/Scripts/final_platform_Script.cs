using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
public class final_platform_Script : MonoBehaviour
{
    
    public GameObject Player;
    PlayerMovement pm;
    private void Start() {
        pm = Player.GetComponent<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player"){
            if(pm.cp2_check()){
                EndScene();
             Debug.Log("----Destination Reached----");

            }
            
        }
    }
    public void EndScene() {  
        SceneManager.LoadScene("EndScene");  
    }  
}
