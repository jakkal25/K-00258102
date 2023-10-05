using System;
using UnityEditor;
using UnityEngine;

internal class DealWithHits:MonoBehaviour
{
    int health = 100;
    internal void IHitYou()
    {
        health -= 20;
        if (health < 0)
        {
            Destroy(this.gameObject);
        }
    }
}