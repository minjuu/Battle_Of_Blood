using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backMng2 : MonoBehaviour
{
    private RectTransform rectTransform;
    int a;

    public GameObject Team1;
    public GameObject Team2;

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

    public Image bg0;
    public Image bg1;
    public Image bg2;
    public Image bg3;
    public Image bg4;

    public Sprite booster;
    public Sprite sonny;
    public Sprite shooter;
    public Sprite healer;
    public Sprite bastion;

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

    public static string T1;
    public static string T2;
    public static string E1;
    public static string E2;
    public static string E3;
    // Start is called before the first frame update
    void Start()
    {
        Team1 = GameObject.FindGameObjectWithTag("team1");
        bg0 = Team1.GetComponent<Image>();

        Team2 = GameObject.FindGameObjectWithTag("team2");
        bg1 = Team2.GetComponent<Image>();

        Enemy1 = GameObject.FindGameObjectWithTag("enemy1");
        bg2 = Enemy1.GetComponent<Image>();

        Enemy2 = GameObject.FindGameObjectWithTag("enemy2");
        bg3 = Enemy2.GetComponent<Image>();

        Enemy3 = GameObject.FindGameObjectWithTag("enemy3");
        bg4 = Enemy3.GetComponent<Image>();

        backMng2.T1 = "0";
        backMng2.T2 = "0";
        backMng2.E1 = "0";
        backMng2.E2 = "0";
        backMng2.E3 = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Char2 != null && Char2.tag == "Team")
        {
            if (backMng2.T1 == "0")
                backMng2.T1 = "sonny";

            else
                backMng2.T2 = "sonny";
        }
        if (Char3 != null && Char3.tag == "Team")
        {
            if (backMng2.T1 == "0")
                backMng2.T1 = "bastion";
            else
                backMng2.T2 = "bastion";
        }
        if (Char4 != null && Char4.tag == "Team")
        {
            if (backMng2.T1 == "0")
                backMng2.T1 = "shooter";
            else
                backMng2.T2 = "shooter";
        }
        if (Char5 != null && Char5.tag == "Team")
        {
            if (backMng2.T1 == "0")
                backMng2.T1 = "healer";
            else
                backMng2.T2 = "healer";
        }
        if (Char6 != null && Char6.tag == "Team")
        {
            if (backMng2.T1 == "0")
                backMng2.T1 = "booster";
            else
                backMng2.T2 = "booster";
        }

        if (backMng2.T1 == "sonny")
        {
            bg0.sprite = sonny;
        }
        if (backMng2.T1 == "bastion")
        {
            bg0.sprite = bastion;
        }
        if (backMng2.T1 == "shooter")
        {
            bg0.sprite = shooter;
        }
        if (backMng2.T1 == "healer")
        {
            bg0.sprite = healer;
        }
        if (backMng2.T1 == "booster")
        {
            bg0.sprite = booster;
        }

        if (backMng2.T2 == "sonny")
        {
            bg1.sprite = sonny;
        }
        if (backMng2.T2 == "bastion")
        {
            bg1.sprite = bastion;
        }
        if (backMng2.T2 == "shooter")
        {
            bg1.sprite = shooter;
        }
        if (backMng2.T2 == "healer")
        {
            bg1.sprite = healer;

        }
        if (backMng2.T2 == "booster")
        {
            bg1.sprite = booster;

        }


        //////////////////////
        if (Char2 != null && Char2.tag == "Enemy")
        {
            if (backMng2.E1 == "0")
                backMng2.E1 = "sonny";
            else if (backMng2.E2 == "0")
                backMng2.E2 = "sonny";
            else 
                backMng2.E3 = "sonny";
        }
        if (Char3 != null && Char3.tag == "Enemy")
        {
            if (backMng2.E1 == "0")
                backMng2.E1 = "bastion";
            else if (backMng2.E2 == "0")
                backMng2.E2 = "bastion";
            else
                backMng2.E3 = "bastion";
        }
        if (Char4 != null && Char4.tag == "Enemy")
        {
            if (backMng2.E1 == "0")
                backMng2.E1 = "shooter";
            else if (backMng2.E2 == "0")
                backMng2.E2 = "shooter";
            else
                backMng2.E3 = "shooter";
        }
        if (Char5 != null && Char5.tag == "Enemy")
        {
            if (backMng2.E1 == "0")
                backMng2.E1 = "healer";
            else if (backMng2.E2 == "0")
                backMng2.E2 = "healer";
            else
                backMng2.E3 = "healer";
        }
        if (Char6 != null && Char6.tag == "Enemy")
        {
            if (backMng2.E1 == "0")
                backMng2.E1 = "booster";
            else if (backMng2.E2 == "0")
                backMng2.E2 = "booster";
            else
                backMng2.E3 = "booster";
        }

        if (backMng2.E1 == "sonny")
        {
            bg2.sprite = sonny;
        }
        if (backMng2.E1 == "bastion")
        {
            bg2.sprite = bastion;
        }
        if (backMng2.E1 == "shooter")
        {
            bg2.sprite = shooter;
        }
        if (backMng2.E1 == "healer")
        {
            bg2.sprite = healer;
        }
        if (backMng2.E1 == "booster")
        {
            bg2.sprite = booster;
        }

        if (backMng2.E2 == "sonny")
        {
            bg3.sprite = sonny;
        }
        if (backMng2.E2 == "bastion")
        {
            bg3.sprite = bastion;
        }
        if (backMng2.E2 == "shooter")
        {
            bg3.sprite = shooter;
        }
        if (backMng2.E2 == "healer")
        {
            bg3.sprite = healer;

        }
        if (backMng2.E2 == "booster")
        {
            bg3.sprite = booster;

        }

        if (backMng2.E3 == "sonny")
        {
            bg4.sprite = sonny;
        }
        if (backMng2.E3 == "bastion")
        {
            bg4.sprite = bastion;
        }
        if (backMng2.E3 == "shooter")
        {
            bg4.sprite = shooter;
        }
        if (backMng2.E3 == "healer")
        {
            bg4.sprite = healer;

        }
        if (backMng2.E3 == "booster")
        {
            bg4.sprite = booster;

        }
    }
}

