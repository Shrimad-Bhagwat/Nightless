using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public WitchItems i;

    public GameObject Player;

    AudioSource audioSrc;
    private void Start() {
        i = Player.GetComponent<WitchItems>();
        audioSrc = GetComponent<AudioSource>();
    }
    private IEnumerator OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            Debug.Log("PickUp Item");
            switch(this.gameObject.name){
                case "mushroom-item-1":
                    audioSrc.Play();
                    yield return new WaitForSeconds (1.0f);
                    // if (!audioSrc.isPlaying)
                    item1.SetActive(false);
                    i.setItem1();
                    break;
                case "skull-item-2":
                    audioSrc.Play();
                    yield return new WaitForSeconds (1.0f);
                    // if (!audioSrc.isPlaying)
                    item2.SetActive(false);
                    i.setItem2();
                    break;
                case "hand-item-3":
                    audioSrc.Play();
                    yield return new WaitForSeconds (1.0f);
                    // if (!audioSrc.isPlaying)
                    item3.SetActive(false);
                    i.setItem3();
                    break;
            }

        }
    }
}
