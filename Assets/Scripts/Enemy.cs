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
    private GameObject player;

    //Score
    ScoreManager points;

    private void Start()
    {
        points = FindAnyObjectByType<ScoreManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        Chase();
    }

    private void Chase()//the enemy moves to were the player is
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        //rotation
        Vector2 dir = new Vector2(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y);

        transform.up = dir;
    }

    private void OnCollisionEnter2D(Collision2D collision) //damages the player
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.GetComponent<Health>() != null)
            {
                collision.gameObject.GetComponent<Health>().Damage(damage);

                

            }
        }
    }



    

}
