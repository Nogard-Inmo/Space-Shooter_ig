using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


public class Enemy : MonoBehaviour
{
    //enemy stats
    [SerializeField] int damage;
    [SerializeField] float speed;
    private EnemyData data;
    private GameObject player;

    //Score
    ScoreManager points;

    private void Start()
    {
        points = FindAnyObjectByType<ScoreManager>();
        player = GameObject.FindGameObjectWithTag("Player");
        SetEnemyValues();
    }

    private void SetEnemyValues()
    {
        GetComponent<Health>().SetHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
    }

    private void Update()
    {
        Chase();
    }

    private void Chase()//the enemy moves to were the player is
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider) //damages the player
    {
        if (collider.CompareTag("Player"))
        {
            if(collider.GetComponent<Health>() != null)
            {
                collider.GetComponent<Health>().Damage(damage);

                

            }
        }
    }



    

}
