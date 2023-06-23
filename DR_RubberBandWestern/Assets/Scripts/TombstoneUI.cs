using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombstoneUI : MonoBehaviour
{
    [SerializeField] Gun gun;

    string previousGunMode;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "TombstoneCollider") {
            previousGunMode = gun.gunMode;
            gun.gunMode = "ui";
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.name == "TombstoneCollider") {
            gun.gunMode = previousGunMode;
        }
    }

    void Start()
    {
        previousGunMode = gun.gunMode;
    }
}
