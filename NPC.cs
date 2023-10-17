using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC Health
    public int health = 5;

    //NPC Level
    public int level = 1;

    //NPC Speed
    public float speed = 1.2f;


    void Start()
    {
        health = health + level;
        print("Lives: " + health);
    }

    void Update()
    {
        //create Vector3
        Vector3 newPosition = transform.position;

        //change z position
        newPosition.z += speed * Time.deltaTime;

        //create npc position
        transform.position = newPosition;
    }
}