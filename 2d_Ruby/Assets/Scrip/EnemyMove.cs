using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyPosition = transform.position;
        enemyPosition.x = enemyPosition.x + moveSpeed * Input.GetAxis("Horizontal");
        //print(Input.GetAxis("Horizontal")); 
        transform.position = enemyPosition;
    }
}
