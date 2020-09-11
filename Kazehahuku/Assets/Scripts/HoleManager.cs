using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleManager : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite HoldSprite;

    bool Filled_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    //void OnCollisionEnter2D(Collision2D other)
    void OnCollisionEnter2D(Collision2D other)
    {
        if(Filled_flag == false){
            // Debug.Log(other.tag); // ぶつかった相手のタグを取得
            if(other.gameObject.tag == "Rock"){
                ChangeStateToHold();
                Destroy(other.gameObject);
                Filled_flag = true;
                GetComponent<CircleCollider2D>().enabled = false;
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
