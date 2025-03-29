using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;  // �̱��� �ν��Ͻ�
    public bool isPlayerDead = false;      // �÷��̾� ���� ����

    private void Awake()
    {
        // ���� �Ŵ��� �ν��Ͻ��� �ϳ��� �����ϵ��� ����
        if (gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ����: �÷��̾ �׾��� �� ȣ���� �Լ�
    public void PlayerDied()
    {
        isPlayerDead = true;
        // �߰������� ���� ���� ó���� ��� �ִϸ��̼� ���� ������ �� �ֽ��ϴ�.
    }

    // ����: �÷��̾ ��Ȱ�� �� ȣ���� �Լ�
    public void PlayerRevived()
    {
        isPlayerDead = false;
        // �߰������� ��Ȱ ó���� �ִϸ��̼� ���� ������ �� �ֽ��ϴ�.
    }
}
