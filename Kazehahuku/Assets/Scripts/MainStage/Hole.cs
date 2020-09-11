using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    //public Sprite StandbySprite;
    public Sprite HoldSprite;

    bool Buried_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(Buried_flag == false){
            // Debug.Log(other.tag); // ぶつかった相手の名前を取得
            if(other.gameObject.tag == "Stone"){
                ChangeStateToHold();
                Destroy(other.gameObject);
                Buried_flag = true;
            }
        }
    }
  

// 何かしらのタイミングで呼ばれる
    void ChangeStateToHold()
    {
       // SpriteRenderのspriteを設定済みの他のspriteに変更
       // 例) HoldSpriteに変更
        MainSpriteRenderer.sprite = HoldSprite;
    }

}
