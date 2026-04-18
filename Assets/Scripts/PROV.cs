using System;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

public class PROV : MonoBehaviour
{

    [SerializeField] private GameObject player;//en variabel
    [SerializeField] private Transform playerPos;

    //private Collider2D playerColider;
    //private Rigidbody2D playerRb;
    //private TMP_Text playerName;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       /* int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 2141, 12454, 345678, 682674, 2112451,  };
        int evenCount = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evenCount++;
                Debug.Log("Even number found: " + num);
            }
        }

        Debug.Log("Total even numbers: " + evenCount);
        */
        if (playerPos == null)
        {
            Debug.LogError("Player position is not assigned!");
        }
        else
        {
            print ("Player position is assigned at: " + playerPos.position);
        }

    }

    // Update is called once per frame
    /*void Update()
    {
        if getKeyDown(gainMoney)
        {
            StartCoroutine(moneyGeneration());
        }
    }


    private IEnumerator moneyGeneration()
    {
        yield return new WaitForSeconds(1);

        money = money + 100;

        StartCoroutine(moneyGeneration());
    }
    */
}
