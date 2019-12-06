using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    Vector3 moveDirection;
    Transform bulletPos;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.frameCount % 1 == 0)
        {

            var position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            position = Camera.main.ScreenToWorldPoint(position);
            var bulletObject = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            bulletObject.transform.LookAt(position);

            bulletObject.GetComponent<Rigidbody2D>().AddForce(bulletObject.transform.forward * 375);

            bulletObject.GetComponent<BulletObject>().hasFired = true;

            bulletObject.AddComponent<CircleCollider2D>();

            bulletObject.layer = 10;

        }
    }



}
