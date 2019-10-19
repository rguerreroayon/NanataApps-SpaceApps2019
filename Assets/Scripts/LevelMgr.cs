using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMgr : MonoBehaviour {


	// Usa esto para inicializar
	void Start () {
		
	}
	
	// La actualizacion se llama una vez por frame
	void Update () {
		
	}

	public void planetX(string NombreNivel){
		SceneManager.LoadScene (NombreNivel);
	}

	public void exit(){
		Application.Quit();
		Debug.Log("bye ");
	}

}
