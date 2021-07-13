using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillMng : MonoBehaviour
{
    private RectTransform rectTransform;
    private RectTransform bar0;
    private RectTransform bar1;
    private RectTransform bar2;
    private RectTransform bar3;

    int a;

    public GameObject Team1;
    public GameObject Team2;

    public GameObject Enemy1;
    public GameObject Enemy2;

    public GameObject char2;
    public GameObject char3;
    public GameObject char4;
    public GameObject char5;
    public GameObject char6;

    public GameObject Char2;
    public GameObject Char3;
    public GameObject Char4;
    public GameObject Char5;
    public GameObject Char6;

    public static string t1;
    public static string t2;
    public static string e1;
    public static string e2;
    // Start is called before the first frame update
    void Start()
    {
        Team1 = GameObject.FindGameObjectWithTag("hb1");
        bar0 = Team1.GetComponent<RectTransform>();
        Team2 = GameObject.FindGameObjectWithTag("hb2");
        bar1 = Team2.GetComponent<RectTransform>();
        Enemy1 = GameObject.FindGameObjectWithTag("eb1");
        bar2 = Enemy1.GetComponent<RectTransform>();
        Enemy2 = GameObject.FindGameObjectWithTag("eb2");
        bar3 = Enemy2.GetComponent<RectTransform>();


        fillMng.e1 = "0";
        fillMng.e2 = "0";

        //rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

        int a = (int)(1.78 * Player.PlayerHp);
        bar0.sizeDelta = new Vector2(a, 12);

        if (char2 != null && char2.tag == "Team")
        {
            //int a = (int)(1.5 * SonnyMove.SonnyHp);
            int b = (int)(1.5 * SonnyMove.SonnyHp);
            bar1.sizeDelta = new Vector2(b, 9);
        }
        if (char3 != null && char3.tag == "Team")
        {
            //int a = (int)(1.5 * BastionMove.BastionHp);
            int b = (int)(1.5 * BastionMove.BastionHp);
            bar1.sizeDelta = new Vector2(b, 9);
        }
        if (char4 != null && char4.tag == "Team")
        {
            //int a = (int)(1.5 * Shooter_Move.ShooterHp);
            int b = (int)(1.5 * Shooter_Move.ShooterHp);
            bar1.sizeDelta = new Vector2(b, 9);
        }
        if (char5 != null && char5.tag == "Team")
        {
            //int a = (int)(1.5 * HealerMove.HealerHp);
            int b = (int)(1.5 * HealerMove.HealerHp);
            bar1.sizeDelta = new Vector2(b, 9);
        }
        if (char6 != null && char6.tag == "Team")
        {
            //int a = (int)(1.5 * BoosterMove.BoosterHp);
            int b = (int)(1.5 * BoosterMove.BoosterHp);
            bar1.sizeDelta = new Vector2(b, 9);
        }


            if (Char2 != null && Char2.tag == "Enemy")
            {
                if (fillMng.e1 == "0")
                {
                    fillMng.e1 = "sonny";
                }
                else
                {
                    fillMng.e2 = "sonny";
                }
            }
            if (Char3 != null && Char3.tag == "Enemy")
            {
                if (fillMng.e1 == "0")
                    fillMng.e1 = "bastion";
                else
                {
                    fillMng.e2 = "bastion";
                    Debug.Log("바스티온두번쨰");
                }
            }
            if (Char4 != null && Char4.tag == "Enemy")
            {
                if (fillMng.e1 == "0")
                    fillMng.e1 = "shooter";
                else
                    fillMng.e2 = "shooter";
            }
            if (Char5 != null && Char5.tag == "Enemy")
            {
                if (fillMng.e1 == "0")
                    fillMng.e1 = "healer";
                else
                    fillMng.e2 = "healer";
            }
            if (Char6 != null && Char6.tag == "Enemy")
            {
                if (fillMng.e1 == "0")
                    fillMng.e1 = "booster";
                else
                    fillMng.e2 = "booster";
            }

            if (fillMng.e1 == "sonny")
            {
                int c = (int)(1.5 * SonnyMove.SonnyHp);
                bar2.sizeDelta = new Vector2(c, 9);
            }
            if (fillMng.e1 == "bastion")
            {
                int c = (int)(1.5 * BastionMove.BastionHp);
                bar2.sizeDelta = new Vector2(c, 9);
            }
            if (fillMng.e1 == "shooter")
            {
                int c = (int)(1.5 * Shooter_Move.ShooterHp);
                bar2.sizeDelta = new Vector2(c, 9);
            }
            if (fillMng.e1 == "healer")
            {
                int c = (int)(1.5 * HealerMove.HealerHp);
                bar2.sizeDelta = new Vector2(c, 9);
            }
            if (fillMng.e1 == "booster")
            {
                int c = (int)(1.5 * BoosterMove.BoosterHp);
                bar2.sizeDelta = new Vector2(c, 9);

            }

            Debug.Log(fillMng.e2);

            if (fillMng.e2 == "sonny")
            {
                int d = (int)(1.5 * SonnyMove.SonnyHp);
                bar3.sizeDelta = new Vector2(d, 9);
            }
            if (fillMng.e2 == "bastion")
            {
                Debug.Log("바스티온체력바");
                int d = (int)(1.5 * BastionMove.BastionHp);
                bar3.sizeDelta = new Vector2(d, 9);
            }
            if (fillMng.e2 == "shooter")
            {
                int d = (int)(1.5 * Shooter_Move.ShooterHp);
                bar3.sizeDelta = new Vector2(d, 9);
            }
            if (fillMng.e2 == "healer")
            {
                int d = (int)(1.5 * HealerMove.HealerHp);
                bar3.sizeDelta = new Vector2(d, 9);

            }
            if (fillMng.e2 == "booster")
            {
                int d = (int)(1.5 * BoosterMove.BoosterHp);
                bar3.sizeDelta = new Vector2(d, 9);
            }
        

        ///////////////





    }
        
}
