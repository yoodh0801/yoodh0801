using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

// 1. ReadOnly 애트리뷰트 정의
[System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class ReadOnlyAttribute : PropertyAttribute
{
}

#if UNITY_EDITOR
// 2. 에디터에서 해당 애트리뷰트가 붙은 필드의 입력을 비활성화하는 PropertyDrawer 정의
[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, label, true);
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // GUI 입력을 일시적으로 비활성화 (회색조로 표시되며 수정 불가)
        GUI.enabled = false;
        EditorGUI.PropertyField(position, property, label, true);
        GUI.enabled = true;
    }
}
#endif