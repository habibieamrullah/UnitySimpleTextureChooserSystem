using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMyTexture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown(){
		Debug.Log("I'm Clicked.");
		MainApp.ma.currentObject = name;
		MainApp.ma.ShowTextureChooser();
	}
}
