using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text dialog;
    public Text c_name;
    public GameObject Btns;
    public Text chose1;
    public Text chose2;

    public bool chose;

    public Characters characters;

    private void Awake()
    {
        Btns.SetActive(false);
    }

    private void Start()
    {
        c_name.text = GameManager.Instance.ch1_n;
        dialog.text = "안녕하세요";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(GameManager.Instance.isPause == false && !chose)
            {
                defaultDialog();
                GameManager.Instance.countDialog++;
            }
        }
    }

    public void defaultDialog()
    {
        switch (GameManager.Instance.countDialog)
        {
            case 0:
                {
                    dialog.text = "이스터 에그 \n 이거 나왔으면 조진거임 ㅇㅇ.. 뭘했길래 버그가 나죠";
                }
                break;
            case 1:
                {
                    dialog.text = "주인공 입니다.";
                }
                break;
            case 2:
                {
                    GameManager.Instance.ch2 = true;
                    c_name.text = GameManager.Instance.ch2_n;
                    dialog.text = "전 상대방입니다";
                }
                break;
            case 3:
                {
                    dialog.text = "문제 드립니다\n제작자가 나온 중학교의 이름은?";
                    Btns.SetActive(true);
                    chose1.text = "석포여자중학교";
                    chose2.text = "대천중학교";
                    chose = true;
                }
                break;
            case 4:
                {
                    if (GameManager.Instance.answerno == true)
                    {
                        dialog.text = "오답";
                        c_name.text = GameManager.Instance.ch1_n;
                        characters.ani();
                        Btns.SetActive(false);
                        chose = false;
                        GameManager.Instance.countDialog++;
                    }
                    else if(GameManager.Instance.answerno == false)
                    {
                        dialog.text = "정답";
                        c_name.text = GameManager.Instance.ch1_n;
                        Btns.SetActive(false);
                        chose = false;
                    }
                }
                break;
            case 5:
                {
                    dialog.text = "test";
                }
                break;
            case 6:
                {
                    dialog.text = "test2";
                }
                break;
            case 7:
                {
                    dialog.text = "test3";
                }
                break;
        }
    }

    //public void Ending1_2()
    //{
    //    dialog.text = "정답";
    //    Btns.SetActive(false);
    //    chose = false;
    //}

    //public void Ending3_4()
    //{
    //    dialog.text = "오답";
    //    characters.ani();
    //    Btns.SetActive(false);
    //    chose = false;
    //}
}
