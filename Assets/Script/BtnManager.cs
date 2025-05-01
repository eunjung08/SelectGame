using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour
{
    public TextManager textManager;
    //º±≈√¡ˆ 1
    public void Chose1()
    {
        GameManager.Instance.answerno = false;
        textManager.defaultDialog();
        //textManager.Ending1_2();
    }

    public void Chose2()
    {
        GameManager.Instance.answerno = true;
        textManager.defaultDialog();
        //textManager.Ending3_4();
    }
}
