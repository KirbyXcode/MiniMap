using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotor : MonoBehaviour {

    public float speed = 4;
    private float timer;
    float hor = 1;
    float ver = 1;

	void Update () 
    {
        timer += Time.deltaTime;

        if (timer >= 3) 
        {
            hor = Random.Range(-1, 1);
            ver = Random.Range(-1, 1);
            timer = 0;
        }
        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime * speed);
	}
}
