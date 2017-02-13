using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour {

    public Button close;

	// Use this for initialization
	void Start () {
        close.onClick.AddListener(() =>
      {
          Application.Quit();
      });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
