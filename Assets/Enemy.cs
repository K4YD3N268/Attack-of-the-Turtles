using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f;
    int hits = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Moving>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.Equals(player))
        {
            Destroy(player);
        }
        if (collision.gameObject.name == "Sphere(Clone)")
        {
            hits += 1;
            print("hit!");
        }
        if (hits >= 7)
        {
            Destroy(gameObject);
        }
    }
}

