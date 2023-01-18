using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frist : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
        int level = 1;
        float Dex = 1.0f;
        string PlayerName = "필봉";
        bool isFullLevel = false;
        

        //연산자

        int exp = 1500;
        exp = exp -10;
        
        level = exp / 300;
        Dex = level * 3.1f;

        Debug.Log ("용사의 총 경험치는?");
        Debug.Log (exp);
        Debug.Log ("용사의 레벨은?");
        Debug.Log (level);
        Debug.Log ("용사의 민첩은?");
        Debug.Log (Dex);

        int nextexp = 300 - (exp % 300);
        Debug.Log ("다음 레벨까지 남은 경험치");
        Debug.Log (nextexp);

        string title = "나약한";
        Debug.Log ("용사의 이름은?");
        Debug.Log (title + "" + PlayerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        Debug.Log ("용사는 만렙입니까? " + isFullLevel);

        //논리 연산자

        int health = 30;
        int mana = 25;

        bool isBadContion = health <= 50 && mana <=20;
        Debug.Log ("용사의 상태가 나쁩니까? "+ isBadContion);

        //혹시
    
        


        


        
    }

    // Update is called once per frame
   
}
