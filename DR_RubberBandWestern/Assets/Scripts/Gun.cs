using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public string gunMode;
    [SerializeField] GameObject bullet, muzzle, lineRend;

    string cachedGunMode;
    bool isShooting;

    public void Shoot(InputAction.CallbackContext context) {
        if (context.started && isShooting) {
            GameObject bulletGO = Instantiate(bullet, muzzle.transform.position, muzzle.transform.rotation);
            bulletGO.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 2000f, 0));
        }
    }

    void CheckGunMode() {
        switch (gunMode)
        {
            case "singleplayer":
                lineRend.SetActive(false);
                isShooting = true;
                break;
            case "multiplayer":
                lineRend.SetActive(false);
                isShooting = true;
                break;
            case "ui":
                lineRend.SetActive(true);
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
    }

    void Update()
    {
        if (gunMode != cachedGunMode) {
            CheckGunMode();
        }
    }
}
