using UnityEngine;

public enum GameState
{
    PrePlay,
    Playing,
    Pause,
    GameOver
}
public class GameManager : MonoBehaviour
{
    static public GameManager Instance;

    public GameState mGameState;
    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }


}