using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Pathfinder pathfinder = FindObjectOfType<Pathfinder>();
        var path = pathfinder.GetPath();
        StartCoroutine(FollowPath(path));
	}

    IEnumerator FollowPath(List<Waypoint>path)
    {
        foreach (var point in path)
        {
            transform.position = point.transform.position;
            yield return new WaitForSeconds(1f);
        }
    }
}
