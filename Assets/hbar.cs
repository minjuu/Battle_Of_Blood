using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hbar : MonoBehaviour
{
    private RectTransform rectTransform;
    int a;
    // Start is called before the first frame update
    void Start()
    {

        rectTransform = GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        int a = (int)(1.78 *Player.PlayerHp);
        rectTransform.sizeDelta = new Vector2(a, 12); 
    }
}
