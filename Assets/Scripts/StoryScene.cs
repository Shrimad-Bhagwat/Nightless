using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StoryScene : MonoBehaviour
{
    int i=0;
    Story story;
    string[] stories = new string[]{"On the night of Halloween, the boundaries between the Human Realm and Spirit Realm are the weakest.",
                                    "The society of wizards stops the spirits from entering and protects the Human Realm.",
                                     "This time to protect the Human realm you need to find the Spell book of the great Wizard Albus."};
    // Start is called before the first frame update
    void Start()
    {
        story = GetComponent<Story>();
    }
    private void Update() {
        
        if(i<3){
            story.SetText(stories[i]);
        }else{
            SceneManager.LoadScene("lvl1");
        }
    }

    public void next(){
        i++;
    }

    
}
