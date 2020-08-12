using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// ********************************************************************
public class SceneName
{
    public const string GAME = "Game";
}
// ********************************************************************

public class LevelLoader : MonoBehaviour
{
    public TMP_Text progressText;
    public Slider progressBar;
    
    // -----------------------------------------------------------------
    public void Start()
    {
        LoadScene(SceneName.GAME);
    }  
    
    // -----------------------------------------------------------------
    private void LoadScene(string sceneName)
    { 
        StartCoroutine(LoadAsynchronously(sceneName));
    }
    
    // -----------------------------------------------------------------
    private IEnumerator LoadAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            progressBar.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }
}
