using UnityEngine;

public class MakeDogTalk : MonoBehaviour
{
    public string mouthButtonName = "Jump";
    private int openHash;
    public bool open;
    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
        openHash = Animator.StringToHash("Open");
    }
    private void Update()
    {
        open = Input.GetButton(mouthButtonName);
        ani.SetBool(openHash, open);
    }
}
