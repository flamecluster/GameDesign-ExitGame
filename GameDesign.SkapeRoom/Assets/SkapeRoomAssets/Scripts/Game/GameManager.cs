using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    private BoardManager BoardScript { get; set; }

    private readonly int level = 1;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        BoardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame()
    {
        BoardScript.SetupScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
