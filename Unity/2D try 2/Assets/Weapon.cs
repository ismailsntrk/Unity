
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Joystick joystick;
    public GameObject bulletPrefab;
    public Transform fireUp;
    

    // Update is called once per frame
    public void Update()
    {
     
        
    }
    public void Shoot()
    { 
        if(Mathf.Abs(joystick.Horizontal) != 0)
        {
            fireUp.Rotate(0f, 0f, 90f);
            Instantiate(bulletPrefab, fireUp.position, fireUp.rotation);
            
        }
        else if (Mathf.Abs(joystick.Vertical) == 0)
        {
            
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        
    }
}
