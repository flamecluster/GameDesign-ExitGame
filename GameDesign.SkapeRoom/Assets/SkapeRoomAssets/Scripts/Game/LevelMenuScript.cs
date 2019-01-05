using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenuScript : MonoBehaviour
{
    public GameObject LevelOption;

    private List<GameObject> _levelOptions;

    void Start()
    {
        InitiateLevelOptions();
    }

    private void InitiateLevelOptions()
    {
        var grid = 341.5f / 5f;
        for (var i = 0; i < 5; i++)
        {
            var pos = new Vector3(36f + (i * grid), 0, 0);
            var levelOption = Instantiate(LevelOption, pos, Quaternion.identity);
            levelOption.GetComponent<LevelOptionButtonScript>().Level = 1;
            levelOption.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = string.Format("Room {0}", i + 1);
            var i1 = i;
            levelOption.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(delegate { TaskOnClick(i1); });

            levelOption.transform.SetParent(transform, false);
        }
    }

    void TaskOnClick(long level)
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!" + level);
        if (level == 1)
        {
            SceneManager.LoadScene("Demo1", LoadSceneMode.Single);
        }
        else if (level == 2)
        {
            SceneManager.LoadScene("Room_2", LoadSceneMode.Single);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
