﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Booster_AI : MonoBehaviour
{
    private Sequence root = new Sequence();             // root 노드 생성
    private Selector selector = new Selector();         // 자식 노드들을 실행시키는 노드 생성
    private Sequence seqMoving = new Sequence();  // Enemy를 이동시키는 sequence 생성
    private Sequence seqDead = new Sequence();    // 죽는 기능을 하는 sequence 생성

    private MoveBooster moveBooster = new MoveBooster();    // 클래스 변수를 생성
    private BoosterTeamPosDetect boosterTeamPosDetect = new BoosterTeamPosDetect();
    private BoosterEnemyPosDetect boosterEnemyPosDetect = new BoosterEnemyPosDetect();
    private BoosterIsDead boosterIsDead = new BoosterIsDead();

    private BoosterMove m_Booster;
    private IEnumerator behaviorProcess;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Tree");
        m_Booster = gameObject.GetComponent<BoosterMove>();
        root.AddChild(selector);
        selector.AddChild(seqDead);         // seqDead 노드를 selector의 자식 노드로 연결
        selector.AddChild(seqMoving); // seqMoving 노드를 selector의 자식 노드로 연결

        moveBooster.Booster = m_Booster;      // m_Enemy를 넣어 초기화시킴
        boosterTeamPosDetect.Booster = m_Booster;
        boosterEnemyPosDetect.Booster = m_Booster;
        boosterIsDead.Booster = m_Booster;

        seqMoving.AddChild(moveBooster);    //seqMoving 노드에 클래스 변수들을 자식으로 추가       
        seqMoving.AddChild(boosterTeamPosDetect);
        seqMoving.AddChild(boosterEnemyPosDetect);

        seqDead.AddChild(boosterIsDead); //seqDead 노드에 클래스 변수를 자식으로 추가

        behaviorProcess = BehaviorProcess();
        StartCoroutine(behaviorProcess);
    }

    public IEnumerator BehaviorProcess()
    {
        while (root.Invoke())
        {
            yield return new WaitForEndOfFrame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Stage2" && count == 0) //스테이지2이면 트리 재시작
        {
            Debug.Log("Start Tree");
            m_Booster = gameObject.GetComponent<BoosterMove>();
            root.AddChild(selector);
            selector.AddChild(seqDead);         // seqDead 노드를 selector의 자식 노드로 연결
            selector.AddChild(seqMoving); // seqMovingAttack 노드를 selector의 자식 노드로 연결

            moveBooster.Booster = m_Booster;      // m_Enemy를 넣어 초기화시킴
            boosterTeamPosDetect.Booster = m_Booster;
            boosterEnemyPosDetect.Booster = m_Booster;
            boosterIsDead.Booster = m_Booster;

            seqMoving.AddChild(moveBooster);    //seqMovingAttack 노드에 클래스 변수들을 자식으로 추가       
            seqMoving.AddChild(boosterTeamPosDetect);
            seqMoving.AddChild(boosterEnemyPosDetect);

            seqDead.AddChild(boosterIsDead); //seqDead 노드에 클래스 변수를 자식으로 추가

            behaviorProcess = BehaviorProcess();
            StartCoroutine(behaviorProcess);

            count++;
        }
    }
}