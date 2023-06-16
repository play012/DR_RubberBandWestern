using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SP_AreaCollision : MonoBehaviour
{
    [SerializeField] Singleplayer spState;
    [SerializeField] TMP_Text scoreText;

    void OnTriggerEnter(Collider coll) {
        foreach (GameObject cGO in spState.cans) {
            if (coll.gameObject == cGO) {
                int score = int.Parse(scoreText.text);
                score++;
                scoreText.text = score.ToString();
            }
        }
    }
}
