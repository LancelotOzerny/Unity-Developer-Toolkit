using TMPro;
using UnityEngine;

public class CounterTMP : MonoBehaviour
{
    [Header("Additional")]
    [SerializeField] private string text_before = string.Empty;
    [SerializeField] private string text_after = string.Empty;

    private TextMeshProUGUI textGUI = null;
    private int value = 0;

    public int Value
    {
        get => value;
    }

    private void Awake()
    {
        this.textGUI = GetComponent<TextMeshProUGUI>();
        SetText();
    }

    public void AddValue(int count)
    {
        this.value += count;
    }

    public void Increment()
    {
        this.value++;
        SetText();
    }

    public void Decrement()
    {
        this.value--;
        SetText();
    }

    public void SetText()
    {
        this.textGUI.text = this.text_before + this.value.ToString() + this.text_after;
    }
}
