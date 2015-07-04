using UnityEngine;
using System.Collections;

public class CameraTopView : MonoBehaviour {

    // Переменные для установки из интерфейса
    public Terrain terrain;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.mousePosition.ToString());
	}
}
