using System;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{

    void Start()
    {
        Show();
        KitchenGameManager.Instance.OnStateChanged += KitchenGameManager_OnStateChanged;

    }

    private void KitchenGameManager_OnStateChanged(object sender, EventArgs e)
    {
        if (KitchenGameManager.Instance.IsCountdownToStartActive())
        {
            Hide();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
