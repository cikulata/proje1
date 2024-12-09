using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint; 
    public float bulletSpeed = 5f; 
    public float fireRate = 1f; 
    private float nextFireTime = 0f; 

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            
            if (Time.time > nextFireTime)
            {
                Shoot(collision.transform);
                nextFireTime = Time.time + 1f / fireRate; 
            }
        }
    }

    void Shoot(Transform target)
    {
        
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Vector2 direction = (target.position - firePoint.position).normalized;
        rb.velocity = direction * bulletSpeed;

        
        Destroy(bullet, 3f);
    }
}

