using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public Transform shooter;
    public Transform bulletPos;

    private void Update()
    {
        bulletPos.position = shooter.position;
    }


}
