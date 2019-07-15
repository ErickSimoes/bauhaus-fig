using System.Collections;
using UnityEngine;

public class Interaction : MonoBehaviour {

    private bool canExit = false;

    void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            Exit();
        }
    }

    private void Exit() {
        if (canExit) {
            Application.Quit();
        } else {
            StartCoroutine(Countdown());
            canExit = true;
        }
    }

    IEnumerator Countdown() {
        yield return new WaitForSeconds(2f);
        canExit = false;
    }
}
