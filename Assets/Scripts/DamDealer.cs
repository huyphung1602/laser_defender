using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamDealer : MonoBehaviour
{
    [SerializeField] int damage = 100;
    [SerializeField] float durationOfHit = 0.2f;

    public int GetDamage() {
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
