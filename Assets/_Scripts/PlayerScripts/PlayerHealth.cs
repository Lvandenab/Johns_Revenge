using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class PlayerHealth : MonoBehaviour
{
    public float health = 10f;
    public float regentime = 0f;
    [SerializeField]
    private TextMeshProUGUI healthUI;

    public GameObject particle;
    public GameObject RedHurt;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthUI(GetHealth());
        RedHurt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0f)
        {
            SceneManager.LoadScene("MainMenu");
        }
        regentime += Time.deltaTime;
        if (regentime >= 2.0)
        {
            if (health < 10f)
            {
                health++;
                UpdateHealthUI(GetHealth());
                regentime = 0f;
                RedHurt.SetActive(false);
            }
            else
            {
                UpdateHealthUI(GetHealth());
                regentime = 0f;
                RedHurt.SetActive(false);

            }
        }
    }

    public string GetHealth()
    {
        return health.ToString();
    }

    public void UpdateHealthUI(string health)
    {
        healthUI.text = health;

    }
    public void LoseHealth()
    {
        health--;
        UpdateHealthUI(GetHealth());
        RedHurt.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            LoseHealth();
            Instantiate(particle, transform.position, Quaternion.identity);

        }
        else if (other.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene("Main Menu");
                
        }
    }
}
