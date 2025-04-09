using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class WinPopup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TimerUI _timerUI;
    [SerializeField] private Button _oneMoreButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private TMP_Text _timerText;

    private void OnEnable()
    {
        _timerText.text = _timerUI.GetFinalTime();

        _oneMoreButton.onClick.AddListener(OnOneMoreButtonClicked);    
    }

    private void OnOneMoreButtonClicked()
    {
        // Tüm DOTween animasyonlarını temizle (Cursor yaptı)
        DOTween.KillAll();
        // Sahneyi yükle
        SceneManager.LoadScene(Consts.SceneNames.GAME_SCENE);
    }
}
