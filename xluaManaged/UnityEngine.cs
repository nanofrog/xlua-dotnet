using System.IO;

namespace UnityEngine
{
    class Object   { }
    struct Vector2 { public float x, y;}
    struct Vector3 { public float x, y, z; }
    struct Vector4 { public float x, y, z, w; }
    struct Color   { public float r, g, b, z; }
    struct Quaternion { public float x, y, z, w; }
    struct Ray   { public Vector3 origin, direction; }
    struct Bounds { public Vector3 center, extents, max, min, size;  }
    struct Ray2D  { public Vector2 origin, direction;  }

    class Debug
    {
        public static void Log(string msg)
        {
#if UNITY_WSA && !UNITY_EDITOR
            
#else
            System.Console.WriteLine(msg);
#endif
        }

        public static void LogWarning(string msg)
        {

        }
    }

    class Application
    {
        public static string streamingAssetsPath = "./";
    }

    class TextAsset
    {
        public string text;
    }

    class Resources
    {
        public static TextAsset Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                return new TextAsset() { text = File.ReadAllText(fileName) };            
            }
            return null;            
        }
    }
}
