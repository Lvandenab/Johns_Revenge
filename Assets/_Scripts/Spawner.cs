using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Spawner : MonoBehaviour
{
    private float spawntimer;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        spawntimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        spawntimer += Time.deltaTime;
        if (spawntimer > 4f)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            spawntimer = 0f;
        }
    }
}
