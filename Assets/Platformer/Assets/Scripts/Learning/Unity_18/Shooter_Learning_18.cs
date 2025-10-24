using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Learning_18 : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireForce;
    [SerializeField] private Transform firePoint;

    public void Shoot(float direction)
    {
        GameObject currentBullet = Instantiate(bullet, firePoint.transform.position, Quaternion.identity);  //Quaternion.identity - никакое вращение;
        Rigidbody2D currentBulletVelocity = currentBullet.GetComponent<Rigidbody2D>();

        if (direction >= 0)
        {
            currentBulletVelocity.velocity = new Vector2(fireForce * 1, currentBulletVelocity.velocity.y);
        }
        else
        {
            currentBulletVelocity.velocity = new Vector2(fireForce * -1, currentBulletVelocity.velocity.y);
        }
    }
}
