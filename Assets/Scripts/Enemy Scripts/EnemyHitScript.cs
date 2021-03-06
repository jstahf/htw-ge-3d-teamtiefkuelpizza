using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitScript : MonoBehaviour
{
    public bool dying;
    public bool claimed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            InitiateDeath();
        }
    }

    public void InitiateDeath()
    {
        dying = true;
        transform.parent.GetComponent<Animator>().SetTrigger("Death");

        GameObject.Find("Score").GetComponent<ScoreScript>().IncreaseScore();
    }
}
