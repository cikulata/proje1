using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint; 
    public float bulletSpeed = 10f; 

    private bool isFacingRight = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            isFacingRight = false;
            Flip();

        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            isFacingRight = true;
            Flip();
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.right * bulletSpeed;
        float direction = isFacingRight ? 1 : -1;
        rb.velocity = new Vector2(bulletSpeed * direction, 0);

        
        Destroy(bullet, 2f);
    }
    void Flip()
    {
        
        Vector3 scale = transform.localScale;
        scale.x = isFacingRight ? Mathf.Abs(scale.x) : -Mathf.Abs(scale.x);
        transform.localScale = scale;

        
        Vector3 firePointPosition = firePoint.localPosition;
        firePointPosition.x = isFacingRight ? Mathf.Abs(firePointPosition.x) : -Mathf.Abs(firePointPosition.x);
        firePoint.localPosition = firePointPosition;
    }
}
