using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObject : MonoBehaviour
{
    public bool hasFired = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DestroyLater());
    }


    public void DestroyBullet()
    {
        Destroy(this.gameObject);
    }

    public IEnumerator DestroyLater()
    {
        yield return new WaitForSeconds(5.0f);

        if (hasFired == true)
        {
            DestroyBullet();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            DestroyBullet();
        }
        
    }
}
