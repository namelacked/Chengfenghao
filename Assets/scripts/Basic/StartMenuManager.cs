using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
   public void SinglePlayerClicked(){
      SceneManager.LoadScene(2);
   }
   public void MultiPlayerClicked(){
      SceneManager.LoadScene(3);
   }
   public void SettingsClicked()
   {
    SceneManager.LoadScene(1);
   }
   public void QuitClicked(){

      Application.Quit();

   }
}
