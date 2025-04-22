using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
   public void SinglePlayerClicked(){

   }

   public void MultiplayerClicked(){

   }
   public void SettingsClicked(){
    SceneManager.LoadScene("SettingScene");
   }
   public void ExitClicked(){
    Application.Quit();









   }
}
