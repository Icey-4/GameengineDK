using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinDisplay : Observer
{
    public Key _key;
    public TextMeshProUGUI _coolText;
    public Sprite _coolSprite;

    private void Start()
    {
        _coolText.gameObject.SetActive(false);
        //_coolSprite.gameObject.SetActive(false);
    }

    public override void Notify(Subject subject)
    {
        _coolText.gameObject.SetActive(true);
    }
}
