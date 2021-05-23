using UnityEditor;

[CustomEditor(typeof(Launcher))]
public class LauncherEditor : Editor
{
    private void OnSceneGUI()
    {
        var launcher = target as Launcher;
        var transform = launcher.transform;
        launcher.offset = transform.InverseTransformDirection(
            Handles.PositionHandle(
                transform.TransformPoint(launcher.offset),
                transform.rotation));
    }
}
