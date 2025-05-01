using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        ch2_image.gameObject.SetActive(false);
    }
    //캐릭터들 차례 설정
    public bool ch1 = false;     //주인공
    public bool ch2 = false;

    public string ch1_n = "주인공";
    public string ch2_n = "상대방";

    public Image ch1_image;
    public Image ch2_image;

    public int countDialog = 1;

    public bool isPause = false;
    public GameObject Pause;

    public bool answerno = false;
    private void Start()
    {
        ch1 = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                isPause = false;
                Time.timeScale = 1;
                Debug.Log("dd");
                Pause.SetActive(false);
            }
            else if (!isPause)
            {
                isPause = true;
                Time.timeScale = 0;
                Debug.Log("dddd");
                Pause.SetActive(true);
            }
        }
        if (ch1)
        {
            ch1_image.gameObject.SetActive(true);
        }
        else
        {
            ch1_image.gameObject.SetActive(false);
        }
        if (ch2)
        {
            ch2_image.gameObject.SetActive(true);
        }
        else
        {
            ch2_image.gameObject.SetActive(false);
        }

        //치트키
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Application.Quit();
        }
    }
}
