using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public string gunMode;
    [SerializeField] GameObject bullet, muzzle;

    GameObject[] shotBullets;
    string cachedGunMode;
    int shootTimer;
    bool isShooting;

    void Shoot() {
        if (isShooting) {
            GameObject bulletGO = Instantiate(bullet, muzzle.transform.position, muzzle.transform.rotation);
            bulletGO.transform.Rotate(0, 90, 90);
            bulletGO.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 700f, 0));
        }
    }

    public void SetGunMode(string mode) {
        gunMode = mode;
    }

    void CheckGunMode() {
        switch (gunMode)
        {
            case "singleplayer":
                isShooting = true;
                break;
            case "multiplayer":
                isShooting = true;
                break;
            case "ui":
                isShooting = false;
                break;
            default:
                break;
        }
        cachedGunMode = gunMode;
    }

    void Start()
    {
        gunMode = "ui";
        cachedGunMode = gunMode;
        shootTimer = 0;
    }

    void Update()
    {
        if (gunMode != cachedGunMode) {
            CheckGunMode();
        }

        shootTimer++;
        if (gunMode != "ui" && OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.5f && shootTimer >= 60) {
            Shoot();
            shootTimer = 0;
        }

        if (shotBullets == null) {
            shotBullets = GameObject.FindGameObjectsWithTag("Bullet");
        }

        foreach (GameObject bulletGO in shotBullets) {
            if (Vector3.Distance(bulletGO.transform.position, muzzle.transform.position) > 100f) {
                Destroy(bulletGO);
            }
        }
    }
}
