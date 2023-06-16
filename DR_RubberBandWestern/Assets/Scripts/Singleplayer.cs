using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleplayer : MonoBehaviour
{
    public GameObject[] cans;
    [SerializeField] GameObject crate, uiGO;
    [SerializeField] Gun gun;

    Vector3[] canPositions;
    Quaternion[] canRotations;

    public void StartSingleplayer()
    {
        crate.transform.position = new Vector3(0, 0, 2.5f);
        foreach (GameObject cGO in cans) {
            int cGOIndex = int.Parse(cGO.name.Substring(11));
            cGO.SetActive(true);
            canPositions[cGOIndex] = cGO.transform.position;
            canRotations[cGOIndex] = cGO.transform.rotation;
        }

        uiGO.SetActive(true);
        gun.gunMode = "singleplayer";
    }

    public void ResetToMenu()
    {
        crate.transform.position = new Vector3(-2, 0, 2.5f);
        foreach (GameObject cGO in cans) {
            int cGOIndex = int.Parse(cGO.name.Substring(11));
            cGO.transform.position = canPositions[cGOIndex];
            cGO.transform.rotation = canRotations[cGOIndex];
            cGO.SetActive(false);
        }
        uiGO.SetActive(false);
        gun.gunMode = "ui";
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
