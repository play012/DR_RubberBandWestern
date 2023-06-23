using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleplayer : MonoBehaviour
{
    public GameObject[] cans;
    [SerializeField] GameObject crate, uiGO, raycastGO;
    [SerializeField] Gun gun;

    Vector3[] canPositions;
    Quaternion[] canRotations;

    public void StartSingleplayer()
    {
        crate.transform.position = new Vector3(0, 0, 2.5f);
        uiGO.SetActive(true);
        raycastGO.SetActive(false);
        gun.gunMode = "singleplayer";
        foreach (GameObject cGO in cans) {
            int cGOIndex = int.Parse(cGO.name.Substring(11));
            cGO.SetActive(true);
            canPositions[cGOIndex] = cGO.transform.position;
            canRotations[cGOIndex] = cGO.transform.rotation;
        }
    }

    public void ResetToMenu()
    {
        crate.transform.position = new Vector3(-2, 0, 2.5f);
        uiGO.SetActive(false);
        raycastGO.SetActive(true);
        gun.gunMode = "ui";
        foreach (GameObject cGO in cans) {
            int cGOIndex = int.Parse(cGO.name.Substring(11));
            cGO.SetActive(false);
            cGO.transform.position = canPositions[cGOIndex];
            cGO.transform.rotation = canRotations[cGOIndex];
        }
    }

    public void ResetCans()
    {
        foreach (GameObject cGO in cans) {
            int cGOIndex = int.Parse(cGO.name.Substring(11));
            cGO.transform.position = canPositions[cGOIndex];
            cGO.transform.rotation = canRotations[cGOIndex];
        }
    }

    void Start() {
        canPositions = new Vector3[cans.Length];
        canRotations = new Quaternion[cans.Length];
    }
}
