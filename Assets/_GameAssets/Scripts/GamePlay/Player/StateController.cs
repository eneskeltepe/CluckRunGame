using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.XR;

public class StateController : MonoBehaviour
{
    private PlayerState _currentPlayerState = PlayerState.Idle;

    public void Start()
    {
        ChangeState(PlayerState.Idle);
    }

    public void ChangeState(PlayerState newPlayerState)
    {
        if (_currentPlayerState == newPlayerState) return;

        _currentPlayerState = newPlayerState;
    }

    public PlayerState GetCurrentState()
    {
        return _currentPlayerState;
    }
}