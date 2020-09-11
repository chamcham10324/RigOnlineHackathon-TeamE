using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class FadeScript : MonoBehaviour
{
    float speed = 1f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    Image im;

    void Start () {
　　　　　//Panelの色を取得
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    public void Fadeout () {
        Debug.Log("clicked");
        im = GetComponent<Image>();
        while(alfa < 1){
            alfa = speed * Time.deltaTime;
            im.color = new Color(red, green, blue, alfa);
        }
        Invoke("LS", 3f);
    }

    public void LS(){
        SceneManager.LoadScene("PlayerTestScene");
    }
}
