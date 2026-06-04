using System.Collections.Generic;
using UnityEngine;

namespace W4Activity
{
    [CreateAssetMenu(fileName = "DialogueLineW4", menuName = "ScriptableObjects/DialogueLine W4 activity", order = 1)]
    public class DialogueNodeW4 : ScriptableObject
    {
        [Tooltip("The line of dialogue the NPC says in this node.")]
        public string Line;

        [Tooltip("[Optional] The dialogue options for the player's response, and what node each response leads to.")]
        public List<PlayerReplyW4> ReplyOptions;

        // --- 新增部分 ---
        [Header("Visual Flair")]
        [Tooltip("当切换到这个对话节点时，想要触发的视觉特效或预制体。")]
        public GameObject VisualFlairPrefab;
        // ----------------
    }
}