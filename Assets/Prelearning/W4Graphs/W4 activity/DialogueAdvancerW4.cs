using UnityEngine;
using Unity.VisualScripting;

namespace W4Activity
{
    public class DialogueAdvancerW4 : MonoBehaviour
    {
        // Singleton stuff- allows this class to be accessed from anywhere in the codebase without a reference (like a member variable)
        // do not edit this line
        public static DialogueAdvancerW4 _Instance {get; private set;}
        [Header("Dialogue Settings")]
        [Tooltip("这是游戏开始时播放的首个对话节点")]
        [SerializeField] private DialogueNodeW4 firstDialogueNode;
        // More Singleton stuff
        // do not edit this method
        private void Awake() {
            if (_Instance != null && _Instance != this) {
                Destroy(this);
                return;
            }

            _Instance = this;
        }
        private void Start()
        {
            if (firstDialogueNode != null)
            {
                ChooseDialogue(firstDialogueNode);
            }
            else
            {
                Debug.LogWarning("你忘记在 Inspector 里拖入初始对话节点了！");
            }
        }
        // Button hooks up to this method
        // do not edit this method
        public void ChooseDialogue (DialogueNodeW4 nextLine)
        {
            EventBus.Trigger(VsEventNames.NewDialogueEvent, nextLine);
        }
    }
}