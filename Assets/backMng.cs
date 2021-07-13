using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backMng : MonoBehaviour
{
    private RectTransform rectTransform;
    int a;

    public GameObject Team;

    public GameObject Enemy1;
    public GameObject Enemy2;

    public Image bg0;
    public Image bg1;
    public Image bg2;

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

    public static string E1;
    public static string E2;
    // Start is called before the first frame update
    void Start()
    {
        Team = GameObject.FindGameObjectWithTag("team1");
        bg0 = Team.GetComponent<Image>();
        Enemy1 = GameObject.FindGameObjectWithTag("enemy1");
        bg1 = Enemy1.GetComponent<Image>();
        Enemy2 = GameObject.FindGameObjectWithTag("enemy2");
        bg2 = Enemy2.GetComponent<Image>();
        backMng.E1 = "0";
        backMng.E2 = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (char2 != null && char2.tag == "Team")
        {
            //int a = (int)(1.5 * SonnyMove.SonnyHp);
            bg0.sprite = sonny;
        }
        if (char3 != null && char3.tag == "Team")
        {
            //int a = (int)(1.5 * BastionMove.BastionHp);
            bg0.sprite = bastion;
        }
        if (char4 != null && char4.tag == "Team")
        {
            //int a = (int)(1.5 * Shooter_Move.ShooterHp);
            bg0.sprite = shooter;
        }
        if (char5 != null && char5.tag == "Team")
        {
            //int a = (int)(1.5 * HealerMove.HealerHp);
            bg0.sprite = healer;
        }
        if (char6 != null && char6.tag == "Team")
        {
            //int a = (int)(1.5 * BoosterMove.BoosterHp);
            bg0.sprite = booster;
        }


            if (Char2 != null && Char2.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "sonny";
           
                else
                    backMng.E2 = "sonny";            
            }
            if (Char3 != null && Char3.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "bastion";
                else
                    backMng.E2 = "bastion";
            }
            if (Char4 != null && Char4.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "shooter";
                else
                    backMng.E2 = "shooter";
            }
            if (Char5 != null && Char5.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "healer";
                else
                    backMng.E2 = "healer";
            }
            if (Char6 != null && Char6.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "booster";
                else
                    backMng.E2 = "booster";
            }

             if (backMng.E1 == "sonny")
             {
                 bg1.sprite = sonny;
             }
             if (backMng.E1 == "bastion")
             {
                 bg1.sprite = bastion;
             }
             if (backMng.E1 == "shooter")
             {
                 bg1.sprite = shooter;
             }
             if (backMng.E1 == "healer")
             {
                  bg1.sprite = healer;
             }
             if (backMng.E1 == "booster")
             {
                 bg1.sprite = booster;
             }

            if (backMng.E2 == "sonny")
            {
                bg2.sprite = sonny;
            }
            if (backMng.E2 == "bastion")
            {
                bg2.sprite = bastion;
            }
            if (backMng.E2 == "shooter")
            {
                bg2.sprite = shooter;
            }
            if (backMng.E2 == "healer")
            {
                bg2.sprite = healer;

            }
            if (backMng.E2 == "booster")
            {
                bg2.sprite = booster;

            }
        
        if (Char2 != null && Char2.tag == "Enemy")
        {
            Debug.Log("");
            if (backMng.E1 == "0")
            {
                backMng.E1 = "sonny";
            }
            else
            {
                backMng.E2 = "sonny";
            }
            }
            if (Char3 != null && Char3.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "bastion";
                else
                    backMng.E2 = "bastion";
            }
            if (Char4 != null && Char4.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "shooter";
                else
                    backMng.E2 = "shooter";
            }
            if (Char5 != null && Char5.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "healer";
                else
                    backMng.E2 = "healer";
            }
            if (Char6 != null && Char6.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "booster";
                else
                    backMng.E2 = "booster";
            }

            if (backMng.E1 == "sonny")
            {
                bg1.sprite = sonny;
            }
            if (backMng.E1 == "bastion")
            {
                bg1.sprite = bastion;
            }
            if (backMng.E1 == "shooter")
            {
                bg1.sprite = shooter;
            }
            if (backMng.E1 == "healer")
            {
                bg1.sprite = healer;
            }
            if (backMng.E1 == "booster")
            {
                bg1.sprite = booster;
            }

            if (backMng.E2 == "sonny")
            {
                bg2.sprite = sonny;
            }
            if (backMng.E2 == "bastion")
            {
                bg2.sprite = bastion;
            }
            if (backMng.E2 == "shooter")
            {
                bg2.sprite = shooter;
            }
            if (backMng.E2 == "healer")
            {
                bg2.sprite = healer;

            }
            if (backMng.E2 == "booster")
            {
                bg2.sprite = booster;

            }

        if (Char2 != null && Char2.tag == "Enemy")
        {
            Debug.Log("");
            if (backMng.E1 == "0")
            {
                backMng.E1 = "sonny";
            }
            else
            {
                backMng.E2 = "sonny";
            }
        }
            if (Char3 != null && Char3.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "bastion";
                else
                    backMng.E2 = "bastion";
            }
            if (Char4 != null && Char4.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "shooter";
                else
                    backMng.E2 = "shooter";
            }
            if (Char5 != null && Char5.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "healer";
                else
                    backMng.E2 = "healer";
            }
            if (Char6 != null && Char6.tag == "Enemy")
            {
                if (backMng.E1 == "0")
                    backMng.E1 = "booster";
                else
                    backMng.E2 = "booster";
            }

            if (backMng.E1 == "sonny")
            {
                bg1.sprite = sonny;
            }
            if (backMng.E1 == "bastion")
            {
                bg1.sprite = bastion;
            }
            if (backMng.E1 == "shooter")
            {
                bg1.sprite = shooter;
            }
            if (backMng.E1 == "healer")
            {
                bg1.sprite = healer;
            }
            if (backMng.E1 == "booster")
            {
                bg1.sprite = booster;
            }

            if (backMng.E2 == "sonny")
            {
                bg2.sprite = sonny;
            }
            if (backMng.E2 == "bastion")
            {
                bg2.sprite = bastion;
            }
            if (backMng.E2 == "shooter")
            {
                bg2.sprite = shooter;
            }
            if (backMng.E2 == "healer")
            {
                bg2.sprite = healer;

            }
            if (backMng.E2 == "booster")
            {
                bg2.sprite = booster;

            }
        

    }
 }

