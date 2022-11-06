using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killer_platform_Script : MonoBehaviour
{
    public GameObject Killer;

    Animator anim;
    Story story;

    private void Start() {
        story = GetComponent<Story>();
        anim = Killer.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player"){
            Debug.Log("Killer Talk Started");
            story.SetText("Ah! You're finally here. I know you are looking for the Spell Book.");
            anim.SetBool("talk_now",true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "Player"){
            Debug.Log("Killer Talk Ended");
            story.SetText("The Wizard lies in one of the coffins and his book along with him. Go have a look.");
            anim.SetBool("talk_now",false);
        }
    }
}
