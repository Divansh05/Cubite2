using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthbar;
    [SerializeField] private Image currenthealthbar;

    private void Start()
    {
        totalhealthbar.fillAmount = playerHealth.currenthealth / 10;
    }

    private void Update()
    {
        currenthealthbar.fillAmount = playerHealth.currenthealth / 10;
    }
}
