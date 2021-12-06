using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyMove : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rubyPosition = transform.position;
        rubyPosition.x = rubyPosition.x + moveSpeed * Input.GetAxis("Horizontal");
        //print(Input.GetAxis("Horizontal")); 
        transform.position = rubyPosition;


    }
    //血量控制1/4
    [Header("最高血量")]  //在檢查器內的輔助顯示
    public int maxHealth = 5;   //定義最高血量值

    [Header("當前血量"), Range(0, 5)]  //檢查武器內的輔助顯示+可調動
    //ivate int currentHelath;       //定義當前血量(不顯示)
    public int currentHelath;        //定義當前血量(顯示在檢查氣)

    //血量控制2/4
    currentHelath = maxHealth
    print("Ruby當前血量為 : " + currentHelath);

}

    // Update is called once per frame
    void FixedUpade()
    
    //血量控制4/4 當前血量為0時，重新遊戲關卡(讀取關卡)
    if (currentHelath ==0)
    {
    Application.LoadLevel("Week12_Health-2_damage");
     }

    }

    //血量控制3/4
    public void ChangeHealth(int amout)
{
    currentHelath = currentHelath + amount;  //加血機制-1
    //currentHelath = Mathf.Clamp(currentHelath + amount, 0, maxHealth); //加寫機制-2 改良版
    print("Ruby 當前血量為:" + currentHelath); //檢查武器是否有加血
}





