using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TitleManager : MonoBehaviour
{
    // public GameObject prefab;
    GameObject refObj;

	void Start() {
		refObj = GameObject.Find("Panel");
	}
    public void OnStartClickd(){
        //Instantiate(prefab, Vector3.zero, Quaternion.identity);
        FadeScript f1 = refObj.GetComponent<FadeScript>();
        f1.Fadeout();
        Invoke("LoadScene", 3f);
        LoadScene();
    }

    public void LoadScene(){
        SceneManager.LoadScene("PlayerTestScene");
    }
}
