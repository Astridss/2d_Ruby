using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �i�����_��
/// </summary>
public class Barry : MonoBehaviour
{
    private void    OnTriggerEnter2D(Collider2D collision)
    {
        RubyMove rubyMove = collision.GetComponent<RubyMove>();
        print("�I�쪺�F��O:" + rubyMove);
        rubyMove.ChangeHealth(1);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
