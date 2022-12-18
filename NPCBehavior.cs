using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    int health;
    int level;
    int speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        health += level; //К здоровью прибавляется уровень NPC 
        print(health); //Выводит значение HP в консоль
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
