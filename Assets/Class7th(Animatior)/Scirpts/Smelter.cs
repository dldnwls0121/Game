using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] float progress;
    [SerializeField] int count;
    public void Success()
    {
       //Debug.Log("����");
    }

    public void Process(float progress)
    {
        this.progress += progress;

        if (this.progress >= 100)
        {
            Debug.Log($"��ȭ ���൵ : {this.progress} �����߽��ϴ�"  );
            this.progress = 0.0f;
        }
        else
        {
            Debug.Log("��ȭ ���൵ : " + this.progress);
        }
    }

    public void Enhance(int count)
    {
        this.count += count;
        Debug.Log("��ȭ Ƚ�� : " + this.count);
    }

}
