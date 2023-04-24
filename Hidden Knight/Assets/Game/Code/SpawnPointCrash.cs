using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointCrash : MonoBehaviour
{
    public void Place()
    {
        Collider2D coll = GetComponent<Collider2D>();
        ContactFilter2D filter = new ContactFilter2D().NoFilter();
        List<Collider2D> results = new List<Collider2D>();
        if (Physics2D.OverlapCollider(coll, filter, results) > 0) Destroy(this.gameObject);
    }
}
