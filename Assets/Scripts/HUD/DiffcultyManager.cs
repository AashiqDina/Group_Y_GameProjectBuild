using UnityEngine;

public enum GameDifficulty
{
    Easy,
    Medium,
    Hard
}

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance { get; private set; }
    public GameDifficulty currentDifficulty = GameDifficulty.Easy; // Default difficulty

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public double GetDamageBasedOnDifficulty()
    {
        switch (currentDifficulty)
        {
            case GameDifficulty.Easy:
                return 0.5;
            case GameDifficulty.Medium:
                return 1.0;
            case GameDifficulty.Hard:
                return 2.0;
            default:
                return 1.0;
        }
    }

    public void SetDifficulty(GameDifficulty difficulty)
    {
        currentDifficulty = difficulty;
    }
}
