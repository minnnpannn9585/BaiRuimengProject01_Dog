using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTextPlay : MonoBehaviour
{
    public Text dialogueText; // 拖拽UI上的Text组件
    public List<string> sentences; // 需要显示的句子
    public float fadeDuration = 1f; // 渐隐渐显时间
    public float displayDuration = 2f; // 每句话停留时间
    public MoreBook moreBook;

    private void Start()
    {
        StartCoroutine(PlayDialogue());
    }

    IEnumerator PlayDialogue()
    {
        foreach (var sentence in sentences)
        {
            // 先设置文本内容，并将alpha设为0
            dialogueText.text = sentence;
            var color = dialogueText.color;
            dialogueText.color = new Color(color.r, color.g, color.b, 0);

            // 渐显
            yield return StartCoroutine(FadeText(0, 1));
            yield return new WaitForSeconds(displayDuration);
            // 渐隐
            yield return StartCoroutine(FadeText(1, 0));
        }
        dialogueText.text = "";
        moreBook.canClick = true;
        gameObject.SetActive(false);
    }

    IEnumerator FadeText(float fromAlpha, float toAlpha)
    {
        float timer = 0f;
        Color color = dialogueText.color;
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(fromAlpha, toAlpha, timer / fadeDuration);
            dialogueText.color = new Color(color.r, color.g, color.b, alpha);
            yield return null;
        }
        dialogueText.color = new Color(color.r, color.g, color.b, toAlpha);
    }
}
