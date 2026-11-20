using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public void GoToPlayScene()
  {
    //name the play scene PlayScene and add it and the MainMenu scene in Build Profiles to the scenes list
    SceneManager.LoadScene("PlayScene");
  }
}
