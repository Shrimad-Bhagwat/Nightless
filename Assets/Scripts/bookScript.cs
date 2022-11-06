using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookScript : MonoBehaviour
{
    Animator anim;
    public GameObject book;
    PlayerMovement pm;  
    public GameObject Player;
    public static GameObject coffin1;
    public static GameObject coffin2;
    public static GameObject coffin3;
    public static GameObject coffin4;
    public static GameObject coffin5;
    int r;
    Story story;

    Transform tr;
    public GameObject[] coffins = new GameObject[]{coffin1,coffin2,coffin3,coffin4,coffin5};
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        pm = Player.GetComponent<PlayerMovement>();
        r = pm.getRandom();
        Debug.Log(coffins[r].gameObject.name);
        tr = coffins[r].gameObject.transform.GetChild(0).transform;
        Debug.Log(tr.transform.name);
        book.transform.position = tr.transform.position;
        story = GetComponent<Story>();
    
    }

    private void OnTriggerEnter(Collider other) {
        
            anim.SetBool("open_book",true);
            Debug.Log("Book Found");
            // story.SetText("Found it!");
        
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "Player"){
            book.SetActive(false);
            pm.cp2_cleared();
            Debug.Log("Book Taken");
            
        }
    }
}
