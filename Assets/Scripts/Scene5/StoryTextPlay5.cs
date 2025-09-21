using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTextPlay5 : MonoBehaviour
{
    public Text dialogueText; // ��קUI�ϵ�Text���
    public List<string> sentences; // ��Ҫ��ʾ�ľ���
    public float fadeDuration = 1f; // ��������ʱ��
    public float displayDuration = 2f; // ÿ�仰ͣ��ʱ��
    public next dog;

    private void Start()
    {
        StartCoroutine(PlayDialogue());
    }

    IEnumerator PlayDialogue()
    {
        foreach (var sentence in sentences)
        {
            // �������ı����ݣ�����alpha��Ϊ0
            dialogueText.text = sentence;
            var color = dialogueText.color;
            dialogueText.color = new Color(color.r, color.g, color.b, 0);

            // ����
            yield return StartCoroutine(FadeText(0, 1));
            yield return new WaitForSeconds(displayDuration);
            // ����
            yield return StartCoroutine(FadeText(1, 0));
        }
        dialogueText.text = "";
        plants.canClick = true;
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
