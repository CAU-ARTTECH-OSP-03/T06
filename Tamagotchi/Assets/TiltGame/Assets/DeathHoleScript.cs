using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHoleScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        BallControlScript.setIsDeadTrue();
    }
}
