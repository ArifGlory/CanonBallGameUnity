using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    private CannonAmmo cannonAmmo;
    public GameObject cannonBallPrefab;
    public Transform cannonShotPoint;
    public float shootForce;


    private void Awake()
    {
        cannonAmmo = GetComponent<CannonAmmo>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (cannonAmmo.CurrentAmmo <= 0)
            {
                cannonAmmo.textAmmo.text = "Peluru habis";
                print("Peluru habis !!");
            }
            else
            {
                Shoot();
            }
            
        }
    }

    void Shoot()
    {
        GameObject cannonBall = Instantiate(cannonBallPrefab, cannonShotPoint.position, cannonShotPoint.rotation);
        cannonBall.GetComponent<Rigidbody>().AddForce(cannonBall.transform.forward * shootForce, ForceMode.Impulse);
        
        cannonAmmo.CurrentAmmo--;

    }

}
