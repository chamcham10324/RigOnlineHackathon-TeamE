using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Vector3 moveDirection;
    private float x;
    private float y;
    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 入力に応じで速度を設定
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            x = 0;
            y = 3;
            playerAnimator.SetBool("Back",true);
            playerAnimator.SetBool("Forward", false);
            playerAnimator.SetBool("Right", false);
            playerAnimator.SetBool("Left", false);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            x = 0;
            y = -3;
            playerAnimator.SetBool("Forward", true);
            playerAnimator.SetBool("Back", false);
            playerAnimator.SetBool("Right", false);
            playerAnimator.SetBool("Left", false);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            x = -3;
            y = 0;
            playerAnimator.SetBool("Left", true);
            playerAnimator.SetBool("Forward", false);
            playerAnimator.SetBool("Back", false);
            playerAnimator.SetBool("Right", false);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            x = 3;
            y = 0;
            playerAnimator.SetBool("Right", true);
            playerAnimator.SetBool("Left", false);
            playerAnimator.SetBool("Forward", false);
            playerAnimator.SetBool("Back", false);
        }
        moveDirection.x = x;
        moveDirection.y = y;

        transform.position += moveDirection * Time.deltaTime;
        transform.rotation = Quaternion.identity;
    }
}
