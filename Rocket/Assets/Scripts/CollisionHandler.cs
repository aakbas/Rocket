using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        
        switch (other.collider.tag){
            case "Finish":
            Debug.Log("game finished");
            FindObjectOfType<LevelLoader>().LoadNextScene();
            break;
            case"Platforms":
            Debug.Log("TouchedPlatform");
            break;
            case"Fuel":
            Debug.Log("Add Fuel");
            break;
            default:
              StartCoroutine(Death());
            break;
        }


         IEnumerator Death(){

             FindObjectOfType<Movement>().Death();
            yield return new WaitForSeconds(1);
              Debug.Log("Game Over");
            FindObjectOfType<LevelLoader>().ReloadScene();

        }

    }
}
