using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject place1;
    public GameObject place2;
    public GameObject place3;
    public WitchItems i;
    public GameObject Player;
    public GameObject Witch;
    Animator a;

    AudioSource audioSrc;
    Story story;

    private void Start() {
        i = Player.GetComponent<WitchItems>();  
        a = Witch.GetComponent<Animator>();
        audioSrc = Witch.GetComponent<AudioSource>();
        story = GetComponent<Story>();
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name=="Player"){
            if(i.checkAll()){
                Debug.Log("All Objects Received");
                item1.transform.position = place1.transform.position;
                item2.transform.position = place2.transform.position;
                item3.transform.position = place3.transform.position;
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                // Checkpoint1 complete 
                Player.GetComponent<PlayerMovement>().cp1_cleared();
                
                a.SetBool("Spell",true);
                story.SetText("");
                audioSrc.Play();

            }else{
                Debug.Log("Collect all objects");
                story.SetText("I'm the gatekeeper of this place and will let you pass only if you prove yourself worthy.");
                a.SetBool("OnPlatform",true);
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        if(!i.checkAll()){

        story.SetText(" Go bring me a rare mushroom, a cursed skull and a severed hand.");
        }else{
            story.SetText("");
        }
    }
    IEnumerator wait(){
        yield return new WaitForSeconds(3.0f);
    }
}
