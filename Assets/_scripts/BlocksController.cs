using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksController : MonoBehaviour
{
    private GameObject[] blocks;
    private GameObject[] objects;

    void Start()
    {
        blocks = GameObject.FindGameObjectsWithTag("block");
        objects = GameObject.FindGameObjectsWithTag("object");
        for (int i = 0; i < blocks.Length; i++)
        {
            blocks[i].GetComponent<Animator>().SetBool("Appear", true);
        }

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].GetComponent<Animator>().SetBool("Appear", true);
        }
    }

    void Update()
    {
        /*
        for (int i = 0; i < blocks.Length; i++)
        {
            Vector3 playerPos = GameObject.Find("Player").transform.position;
            Vector3 blockPos = blocks[i].transform.position;
            float distance = (playerPos - blockPos).magnitude;
            if (distance > 60)
            {
                blocks[i].GetComponent<Animator>().SetBool("Appear", false);
            }
            else
            {
                blocks[i].GetComponent<Animator>().SetBool("Appear", true);
            }
        }

        for (int i = 0; i < objects.Length; i++)
        {
            Vector3 playerPos = GameObject.Find("Player").transform.position;
            Vector3 objectPos = objects[i].transform.position;
            float distance = (playerPos - objectPos).magnitude;
            if (distance > 60)
            {
                objects[i].GetComponent<Animator>().SetBool("Appear", false);
            }
            else
            {
                objects[i].GetComponent<Animator>().SetBool("Appear", true);
            }
        }
        */

        if (GameObject.Find("Player").transform.position.y < -5)
        {
            Application.Quit();
        }
    }
}
