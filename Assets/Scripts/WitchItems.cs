using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchItems : MonoBehaviour
{

    public bool item1,item2,item3 = false;

    public void setItem1(){
        item1 = true;
    }

    public void setItem2(){
        item2 = true;
    }

    public void setItem3(){
        item3 = true;
    }
    public bool checkAll() {
        if(item1 && item2 && item3){
            return true;
        }
        else {
            return false;
        }
    }
}
