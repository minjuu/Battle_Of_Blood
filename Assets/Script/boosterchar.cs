using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class boosterchar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public GameObject enemycharacter1;
    public GameObject enemycharacter2;
    public GameObject enemycharacter3;
    public GameObject enemycharacter4;


    // Start is called before the first frame update
    public void onStart()
    {

        if (SceneManager.GetActiveScene().name == "selectchar") // 스테이지1 캐릭터 선택 씬일 경우
        {
            character.gameObject.tag = "Team"; // 해당 버튼 클릭시 캐릭터 태그 변경
            enemycharacter1.gameObject.tag = "Enemy"; // 지정된 캐릭터를 적으로 선택
            enemycharacter2.gameObject.tag = "Enemy"; // 지정된 캐릭터를 적으로 선택
            enemycharacter3 = null;

            SelectMng.booster1 = "Team";  // 해당 버튼 클릭시 캐릭터 태그 저장 변수 변경
            SelectMng.shooter1 = "Enemy"; // 적 캐릭터의 태그 스트링 저장
            SelectMng.sonny1 = "Enemy"; // 적 캐릭터의 태그 스트링 저장
            SelectMng.bastion1 = "";
            SceneManager.LoadScene("SampleScene"); //스테이지 1로 이동
        }

        if (SceneManager.GetActiveScene().name == "selectchar2") // 스테이지2 캐릭터 선택 씬일 경우
        {
            character.gameObject.tag = "Team"; // 해당 버튼 클릭시 캐릭터 태그 변경
            SelectMng.booster1 = "Team"; // 해당 버튼 클릭시 캐릭터 태그 저장 변수 변경
            SelectMng.selectcount++;

            SceneManager.LoadScene("selectchar3");

        }
        if (SceneManager.GetActiveScene().name == "selectchar3") // 스테이지2 두번째 캐릭터 선택 씬일 경우
        {
            character.gameObject.tag = "Team"; // 해당 버튼 클릭시 캐릭터 태그 변경
            SelectMng.booster1 = "Team"; // 해당 버튼 클릭시 캐릭터 태그 저장 변수 변경
            SelectMng.selectcount++;

            Debug.Log("end");
            if (enemycharacter1.gameObject.tag != "Team" && SelectMng.enemycount < 3)
            {
                // 팀으로 선택되지 못한 캐릭터의 태그를 적으로 변경
                // 팀으로 선택되지 못한 캐릭터의 태그를 string 변수에 저장
                enemycharacter1.gameObject.tag = "Enemy";
                SelectMng.bastion1 = "Enemy";
                SelectMng.enemycount++;
            }
            if (enemycharacter2.gameObject.tag != "Team" && SelectMng.enemycount < 3)
            {
                // 팀으로 선택되지 못한 캐릭터의 태그를 적으로 변경
                // 팀으로 선택되지 못한 캐릭터의 태그를 string 변수에 저장
                enemycharacter2.gameObject.tag = "Enemy";
                SelectMng.shooter1 = "Enemy";
                SelectMng.enemycount++;
            }
            if (enemycharacter3.gameObject.tag != "Team" && SelectMng.enemycount < 3)
            {
                // 팀으로 선택되지 못한 캐릭터의 태그를 적으로 변경
                // 팀으로 선택되지 못한 캐릭터의 태그를 string 변수에 저장
                enemycharacter3.gameObject.tag = "Enemy";
                SelectMng.sonny1 = "Enemy";
                SelectMng.enemycount++;
            }
            if (enemycharacter4.gameObject.tag != "Team" && SelectMng.enemycount < 3)
            {
                // 팀으로 선택되지 못한 캐릭터의 태그를 적으로 변경
                // 팀으로 선택되지 못한 캐릭터의 태그를 string 변수에 저장
                enemycharacter4.gameObject.tag = "Enemy";
                SelectMng.healer1 = "Enemy";
                SelectMng.enemycount++;
            }

            SceneManager.LoadScene("Stage2"); //스테이지 2로 이동
            //}
        }
    }
}