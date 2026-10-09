using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] public float cooldownTime = 0.5f;

    private float cooldownCounter = 0f;

    void Update()
    {
        Shoot();
    }

    void Shoot() 
    { 
        cooldownCounter += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && cooldownCounter > cooldownTime)
        {
            GameObject laser = Instantiate(laserPrefab);
            laser.transform.position = transform.position;
            laser.transform.rotation = transform.rotation;
            
            // Ruim de laser na 3 seconden op uit het geheugen
            Destroy(laser, 3f);

            cooldownCounter = 0f;
        }   
    }
}