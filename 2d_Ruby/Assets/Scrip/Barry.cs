using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 可收集寶物
/// </summary>
public class Barry : MonoBehaviour
{
    private void    OnTriggerEnter2D(Collider2D collision)
    {
        RubyMove rubyMove = collision.GetComponent<RubyMove>();
        print("碰到的東西是:" + rubyMove);
        rubyMove.ChangeHealth(1);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
