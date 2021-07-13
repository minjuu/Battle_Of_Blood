using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillMng2 : MonoBehaviour
{
    private RectTransform rectTransform;
    private RectTransform bar0;
    private RectTransform bar1;
    private RectTransform bar2;
    private RectTransform bar3;
    private RectTransform bar4;

    int a;

    public GameObject Team1;
    public GameObject Team2;

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

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
    public static string e3;
    // Start is called before the first frame update
    void Start()
    {
        Team1 = GameObject.FindGameObjectWithTag("hb2");
        bar0 = Team1.GetComponent<RectTransform>();

        Team2 = GameObject.FindGameObjectWithTag("hb3");
        bar1 = Team2.GetComponent<RectTransform>();

        Enemy1 = GameObject.FindGameObjectWithTag("eb1");
        bar2 = Enemy1.GetComponent<RectTransform>();

        Enemy2 = GameObject.FindGameObjectWithTag("eb2");
        bar3 = Enemy2.GetComponent<RectTransform>();

        Enemy3 = GameObject.FindGameObjectWithTag("eb3");
        bar4 = Enemy3.GetComponent<RectTransform>();

        fillMng2.t1 = "0";
        fillMng2.t2 = "0";
        fillMng2.e1 = "0";
        fillMng2.e2 = "0";
        fillMng2.e3 = "0";

        //rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Char2 != null && Char2.tag == "Team")
        {
            if (fillMng2.t1 == "0")
            {
                fillMng2.t1 = "sonny";
            }
            else
            {
                fillMng2.t2 = "sonny";
            }
        }
        if (Char3 != null && Char3.tag == "Team")
        {
            if (fillMng2.t1 == "0")
                fillMng2.t1 = "bastion";
            else
                fillMng2.t2 = "bastion";
        }
        if (Char4 != null && Char4.tag == "Team")
        {
            if (fillMng2.t1 == "0")
                fillMng2.t1 = "shooter";
            else
                fillMng2.t2 = "shooter";
        }
        if (Char5 != null && Char5.tag == "Team")
        {
            if (fillMng2.t1 == "0")
                fillMng2.t1 = "healer";
            else
                fillMng2.t2 = "healer";
        }
        if (Char6 != null && Char6.tag == "Team")
        {
            if (fillMng2.t1 == "0")
                fillMng2.t1 = "booster";
            else
                fillMng2.t2 = "booster";
        }

        if (fillMng2.t1 == "sonny")
        {
            int c = (int)(1.5 * SonnyMove.SonnyHp);
            bar0.sizeDelta = new Vector2(c, 9);
        }
        if (fillMng2.t1 == "bastion")
        {
            int c = (int)(1.5 * BastionMove.BastionHp);
            bar0.sizeDelta = new Vector2(c, 9);
        }
        if (fillMng2.t1 == "shooter")
        {
            int c = (int)(1.5 * Shooter_Move.ShooterHp);
            bar0.sizeDelta = new Vector2(c, 9);
        }
        if (fillMng2.t1 == "healer")
        {
            int c = (int)(1.5 * HealerMove.HealerHp);
            bar0.sizeDelta = new Vector2(c, 9);
        }
        if (fillMng2.t1 == "booster")
        {
            int c = (int)(1.5 * BoosterMove.BoosterHp);
            bar0.sizeDelta = new Vector2(c, 9);

        }

        if (fillMng2.t2 == "sonny")
        {
            int d = (int)(1.5 * SonnyMove.SonnyHp);
            bar1.sizeDelta = new Vector2(d, 9);
        }
        if (fillMng2.t2 == "bastion")
        {
            int d = (int)(1.5 * BastionMove.BastionHp);
            bar1.sizeDelta = new Vector2(d, 9);
        }
        if (fillMng2.t2 == "shooter")
        {
            int d = (int)(1.5 * Shooter_Move.ShooterHp);
            bar1.sizeDelta = new Vector2(d, 9);
        }
        if (fillMng2.t2 == "healer")
        {
            int d = (int)(1.5 * HealerMove.HealerHp);
            bar1.sizeDelta = new Vector2(d, 9);

        }
        if (fillMng2.t2 == "booster")
        {
            int d = (int)(1.5 * BoosterMove.BoosterHp);
            bar1.sizeDelta = new Vector2(d, 9);
        }


        ///////////////
        if (Char2 != null && Char2.tag == "Enemy")
        {
            if (fillMng2.e1 == "0")
                fillMng2.e1 = "sonny";
            else if (fillMng2.e2 == "0")
                fillMng2.e2 = "sonny";
            else
                fillMng2.e3 = "sonny";
        }
        if (Char3 != null && Char3.tag == "Enemy")
        {
            if (fillMng2.e1 == "0")
                fillMng2.e1 = "bastion";
            else if (fillMng2.e2 == "0")
                fillMng2.e2 = "bastion";
            else
                fillMng2.e3 = "bastion";
        }
        if (Char4 != null && Char4.tag == "Enemy")
        {
            if (fillMng2.e1 == "0")
                fillMng2.e1 = "shooter";
            else if (fillMng2.e2 == "0")
                fillMng2.e2 = "shooter";
            else
                fillMng2.e3 = "shooter";
        }
        if (Char5 != null && Char5.tag == "Enemy")
        {
            if (fillMng2.e1 == "0")
                fillMng2.e1 = "healer";
            else if (fillMng2.e2 == "0")
                fillMng2.e2 = "healer";
            else
                fillMng2.e3 = "healer";
        }
        if (Char6 != null && Char6.tag == "Enemy")
        {
            if (fillMng2.e1 == "0")
                fillMng2.e1 = "booster";
            else if (fillMng2.e2 == "0")
                fillMng2.e2 = "booster";
            else
                fillMng2.e3 = "booster";
        }

        if (fillMng2.e1 == "sonny")
        {
            int a = (int)(1.5 * SonnyMove.SonnyHp);
            bar2.sizeDelta = new Vector2(a, 9);
        }
        if (fillMng2.e1 == "bastion")
        {
            int a = (int)(1.5 * BastionMove.BastionHp);
            bar2.sizeDelta = new Vector2(a, 9);
        }
        if (fillMng2.e1 == "shooter")
        {
            int a = (int)(1.5 * Shooter_Move.ShooterHp);
            bar2.sizeDelta = new Vector2(a, 9);
        }
        if (fillMng2.e1 == "healer")
        {
            int a = (int)(1.5 * HealerMove.HealerHp);
            bar2.sizeDelta = new Vector2(a, 9);
        }
        if (fillMng2.e1 == "booster")
        {
            int a = (int)(1.5 * BoosterMove.BoosterHp);
            bar2.sizeDelta = new Vector2(a, 9);
        }

        if (fillMng2.e2 == "sonny")
        {
            int b = (int)(1.5 * SonnyMove.SonnyHp);
            bar3.sizeDelta = new Vector2(b, 9);
        }
        if (fillMng2.e2 == "bastion")
        {
            int b = (int)(1.5 * BastionMove.BastionHp);
            bar3.sizeDelta = new Vector2(b, 9);
        }
        if (fillMng2.e2 == "shooter")
        {
            int b = (int)(1.5 * Shooter_Move.ShooterHp);
            bar3.sizeDelta = new Vector2(b, 9);
        }
        if (fillMng2.e2 == "healer")
        {
            int b = (int)(1.5 * HealerMove.HealerHp);
            bar3.sizeDelta = new Vector2(b, 9);
        }
        if (fillMng2.e2 == "booster")
        {
            int b = (int)(1.5 * BoosterMove.BoosterHp);
            bar3.sizeDelta = new Vector2(b, 9);
        }

        if (fillMng2.e3 == "sonny")
        {
            int e = (int)(1.5 * SonnyMove.SonnyHp);
            bar4.sizeDelta = new Vector2(e, 9);
        }
        if (fillMng2.e3 == "bastion")
        {
            int e = (int)(1.5 * BastionMove.BastionHp);
            bar4.sizeDelta = new Vector2(e, 9);
        }
        if (fillMng2.e3 == "shooter")
        {
            int e = (int)(1.5 * Shooter_Move.ShooterHp);
            bar4.sizeDelta = new Vector2(e, 9);
        }
        if (fillMng2.e3 == "healer")
        {
            int e = (int)(1.5 * HealerMove.HealerHp);
            bar4.sizeDelta = new Vector2(e, 9);
        }
        if (fillMng2.e3 == "booster")
        {
            int e = (int)(1.5 * BoosterMove.BoosterHp);
            bar4.sizeDelta = new Vector2(e, 9);
        }




    }

}
