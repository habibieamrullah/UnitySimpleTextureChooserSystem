using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainApp : MonoBehaviour
{
	
	public GameObject textureChooser;
	public Text objName;
	
	public static MainApp ma;
	
	[HideInInspector]
	public string currentObject;
	
    // Start is called before the first frame update
    void Start()
    {
        ma = this;
		currentObject = "";
		objName.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void ShowTextureChooser(){
		textureChooser.SetActive(true);
		objName.text = currentObject;
	}
	
	public void HideTextureChooser(){
		textureChooser.SetActive(false);
	}
	
	public void SetThisTexture(string texNumber){
		Debug.Log("Current selected object is " + currentObject);
		GameObject obj = GameObject.Find(currentObject);
		obj.GetComponent<Renderer>().material.mainTexture = Resources.Load<Texture2D>("texture" + texNumber);
	}
}
