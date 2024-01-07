using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDamage : MonoBehaviour
{
    public int enemydamage = 1;
    public float DamageRate;
    private float DamageLastDone;
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !CanDamage())
        {
            double actualDamage = enemydamage * DifficultyManager.Instance.GetDamageBasedOnDifficulty();
            enemydamage = 0;
        }

    }

    bool CanDamage()
    {
        if (Time.time - DamageLastDone > DamageRate)
        {
            DamageLastDone = Time.time;
            return true;
        }
        return false;
    }
}
