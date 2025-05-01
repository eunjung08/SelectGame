using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public RectTransform ch1_im;
    public int count_move;
    public bool stopmove;

    public void ani()
    {
        if (!stopmove)
        {
            count_move++;
            int yPos = 5;
            ch1_im.anchoredPosition = new Vector2(ch1_im.anchoredPosition.x, yPos);
            Invoke("returnPos", 0.1f);
        }
    }
    
    public void returnPos()
    {
        if (!stopmove)
        {
            count_move++;
            int yPos = 3;
            ch1_im.anchoredPosition = new Vector2(ch1_im.anchoredPosition.x, yPos);
            Invoke("ani", 0.1f);
        }
    }
    private void Start()
    {
    }

    private void Update()
    {
        if (count_move == 6)
        {
            stopmove = true;
        }
    }
}
