using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TestObject : MonoBehaviour {

    string helloworld = "Hello World";

    public TextMeshProUGUI Text;

    public void PrintHelloWorld()
    {
        Debug.Log(helloworld);
        GetComponent<TextMeshProUGUI>().text = "Hi";

        

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
