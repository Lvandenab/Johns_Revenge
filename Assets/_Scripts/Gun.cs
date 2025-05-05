
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public float damage = 1f;
    public float range = 100f;

    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("mouse 0"))
        {
            shoot();
        }
    }

    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.takedamage(damage);
            }

        }
        
    }
}
