using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject fireBall;
    public Transform attackPoint;
    public float attackSpeed = 600;

    public void FireBallAttack()
    {
        GameObject ball = Instantiate(fireBall, attackPoint.position, Quaternion.identity);
        ball.GetComponent<Rigidbody>().AddForce(attackPoint.forward * attackSpeed);
    }
}
