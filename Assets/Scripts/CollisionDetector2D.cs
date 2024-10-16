using UnityEngine;

using UnityEngine.SceneManagement;

public class CollisionDetector2D : MonoBehaviour
{
    // Se llama cuando el objeto comienza a colisionar con otro objeto
   public void LoadScene(){
    SceneManager.LoadScene("Level1");
   }
}
