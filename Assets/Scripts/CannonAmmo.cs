using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CannonAmmo : MonoBehaviour
{
    public int totalAmmo;
    public int currentAmmo;
    public TextMeshProUGUI textAmmo;

    public int CurrentAmmo
    {
        get {
            return currentAmmo;
        }
        set
        {
            currentAmmo = value;
            textAmmo.text = "Peluru "+currentAmmo+" / "+totalAmmo;
            print("Current Ammo skrg : " + currentAmmo);
        }
    }

    private void Start()
    {
        currentAmmo = totalAmmo;
    }
}
