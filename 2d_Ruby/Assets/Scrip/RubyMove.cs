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
    //��q����1/4
    [Header("�̰���q")]  //�b�ˬd���������U���
    public int maxHealth = 5;   //�w�q�̰���q��

    [Header("��e��q"), Range(0, 5)]  //�ˬd�Z���������U���+�i�հ�
    //ivate int currentHelath;       //�w�q��e��q(�����)
    public int currentHelath;        //�w�q��e��q(��ܦb�ˬd��)

    //��q����2/4
    currentHelath = maxHealth
    print("Ruby��e��q�� : " + currentHelath);

}

    // Update is called once per frame
    void FixedUpade()
    
    //��q����4/4 ��e��q��0�ɡA���s�C�����d(Ū�����d)
    if (currentHelath ==0)
    {
    Application.LoadLevel("Week12_Health-2_damage");
     }

    }

    //��q����3/4
    public void ChangeHealth(int amout)
{
    currentHelath = currentHelath + amount;  //�[�����-1
    //currentHelath = Mathf.Clamp(currentHelath + amount, 0, maxHealth); //�[�g����-2 ��}��
    print("Ruby ��e��q��:" + currentHelath); //�ˬd�Z���O�_���[��
}





