using ScriptableEvents.Events;
using UnityEditor;
using UnityEngine;

namespace ScriptableEvents.Editor.Events
{
    [CustomEditor(typeof(GameObjectScriptableEvent))]
    public class GameObjectScriptableEventEditor : TypedScriptableEventEditor<GameObject>
    {
        protected override GameObject DrawArgField(GameObject value)
        {
            return EditorGUILayout.ObjectField(value, typeof(GameObject), true) as GameObject;
        }
    }
}
