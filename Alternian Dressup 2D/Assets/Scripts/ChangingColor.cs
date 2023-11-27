using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingColor : MonoBehaviour{

    public GameObject panel;

    public SpriteRenderer Base;
    public Image squareBaseDisplay;

    public Color white;
    public Color grey;
    public Color darkgrey;

    public int whatColor = 1;

    void Update(){

        squareBaseDisplay.color = Base.color;

        if (whatColor == 1)
        {
            Base.color = white;
        }
        else if (whatColor == 2)
        {
            Base.color = grey;
        }
        else if (whatColor == 3)
        {
            Base.color = darkgrey;
        }
    }
    
    public void OpenPanel(){

        panel.SetActive(true);
    }

    public void ClosePanel(){

        panel.SetActive(false);
    }

    public void ChangeBaseWhite(){
        whatColor = 1;
    }

    public void ChangeBaseGrey(){
        whatColor = 2;
    } 
    
    public void ChangeBaseDarkGrey(){
        whatColor = 3;
    }
}
