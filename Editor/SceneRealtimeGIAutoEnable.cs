using UnityEditor;
using UnityEditor.Callbacks;

#if BAKERY_INCLUDED
static public class SceneRealtimeGIAutoEnable
{
    [PostProcessSceneAttribute]
    static void OnPostProcessScene()
    {
        Lightmapping.realtimeGI = true;
    }

    [PostProcessBuildAttribute]
    static void OnPostProcessBuild(BuildTarget buildTarget, string path)
    {
        Lightmapping.realtimeGI = true;
    }
}
#endif
