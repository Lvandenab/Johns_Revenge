using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : Interactable
{
    [SerializeField]
    private GameObject exit;
    private bool exitopen;

    public GameObject particle;
    public GameObject Thisegg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // this is the code for the item when interacted with
    protected override void Interact()
    {
        exitopen = !exitopen;
        Destroy(Thisegg);
        Instantiate(particle,transform.position, Quaternion.identity);
        Destroy(exit);
    }
}
