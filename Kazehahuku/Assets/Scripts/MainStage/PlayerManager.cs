using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] ResultManager resultManager;
    private Vector3 moveDirection;
    private float x;
    private float y;
    private Animator playerAnimator;
    private Rigidbody2D rb;
    private PlayerStatus playerStatus = PlayerStatus.LF;
    private float damage;
    private float operation;
    private int minute;
    private float seconds;
    private bool goal;
    private float score;

    public enum PlayerStatus
    { 
        RF,
        LF,
        RB,
        LB
    }

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }

        if (!goal)
        {
            // 入力に応じで速度を設定
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                x = 0;
                y = 3;

                if (playerStatus == PlayerStatus.RF)
                {
                    playerAnimator.SetBool("RF", false);
                    playerAnimator.SetBool("LF", false);
                    playerAnimator.SetBool("RB", true);
                    playerAnimator.SetBool("LB", false);
                    playerStatus = PlayerStatus.RB;
                }

                if (playerStatus == PlayerStatus.LF)
                {
                    playerAnimator.SetBool("RF", false);
                    playerAnimator.SetBool("LF", false);
                    playerAnimator.SetBool("RB", false);
                    playerAnimator.SetBool("LB", true);
                    playerStatus = PlayerStatus.LB;
                }

                operation += 1;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                x = 0;
                y = -3;

                if (playerStatus == PlayerStatus.RB)
                {
                    playerAnimator.SetBool("RF", true);
                    playerAnimator.SetBool("LF", false);
                    playerAnimator.SetBool("RB", false);
                    playerAnimator.SetBool("LB", false);
                    playerStatus = PlayerStatus.RF;
                }

                if (playerStatus == PlayerStatus.LB)
                {
                    playerAnimator.SetBool("RF", false);
                    playerAnimator.SetBool("LF", true);
                    playerAnimator.SetBool("RB", false);
                    playerAnimator.SetBool("LB", false);
                    playerStatus = PlayerStatus.LF;
                }

                operation += 1;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                x = -3;
                y = 0;

                if (playerStatus == PlayerStatus.RF)
                {
                    playerAnimator.SetBool("RF", false);
                    playerAnimator.SetBool("LF", true);
                    playerAnimator.SetBool("RB", false);
                    playerAnimator.SetBool("LB", false);
                    playerStatus = PlayerStatus.LF;
                }

                if (playerStatus == PlayerStatus.RB)
                {
                    playerAnimator.SetBool("RF", false);
                    playerAnimator.SetBool("LF", false);
                    playerAnimator.SetBool("RB", false);
                    playerAnimator.SetBool("LB", true);
                    playerStatus = PlayerStatus.LB;
                }

                operation += 1;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                x = 3;
                y = 0;

                if (playerStatus == PlayerStatus.LB)
                {
                    playerAnimator.SetBool("RF", false);
                    playerAnimator.SetBool("LF", false);
                    playerAnimator.SetBool("RB", true);
                    playerAnimator.SetBool("LB", false);
                    playerStatus = PlayerStatus.RB;
                }

                if (playerStatus == PlayerStatus.LF)
                {
                    playerAnimator.SetBool("RF", true);
                    playerAnimator.SetBool("LF", false);
                    playerAnimator.SetBool("RB", false);
                    playerAnimator.SetBool("LB", false);
                    playerStatus = PlayerStatus.RF;
                }

                operation += 1;
            }
        }

        moveDirection.x = x;
        moveDirection.y = y;
        rb.velocity = Vector3.zero;

        transform.position += moveDirection * Time.deltaTime;
        transform.rotation = Quaternion.identity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ゴールしたら
        if(collision.gameObject.tag == "Goal")
        {
            score = minute * 60 + seconds + damage * 10 + operation;
            resultManager.ResultStart(minute.ToString("00") + ":" + ((int)seconds).ToString("00"), damage, operation, score);
            moveDirection = Vector3.zero;
            goal = true;
            x = 0;
            y = 0;
            playerAnimator.Play("Goal");
        }

        // 何かにぶつかったら
        if(collision.gameObject.tag == "Rock")
        {
            damage += 1;
        }
    }
}
