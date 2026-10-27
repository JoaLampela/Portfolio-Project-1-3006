using UnityEngine;

[CreateAssetMenu(fileName = "PlayerControllerSettingsSO", menuName = "My Menu/Player Controller SettingsSO")]
public class PlayerControllerSettingsSO : ScriptableObject
{
    [Header("Movement")]
    [Range(1f, 10f)]
    [Tooltip("Player movement speed in units per second.")]
    public float MoveSpeed = 5f;
    public bool InvertControls = false;

    [Header("Appearance")]
    public Color PlayerColor = Color.green;

    [Header("Description")]
    [TextArea(2, 6)]
    [SerializeField]
    private string _description = "Simple player configuration.";
}
