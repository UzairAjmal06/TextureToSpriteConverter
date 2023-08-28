//place this script in your Unity project's "Editor" folder. If the "Editor" folder doesn't exist, create it in the root of your "Assets" folder.

using UnityEditor;

public class TextureToSpriteConverter : AssetPostprocessor
{
    private void OnPreprocessTexture()
    {
        // Check if the asset is in the specified folder
        string assetPath = assetImporter.assetPath;
        if (assetPath.Contains("/UI/") && !assetPath.EndsWith(".meta"))
        {
            TextureImporter textureImporter = assetImporter as TextureImporter;

            // Change the texture type to Sprite (2D UI)
            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.spriteImportMode = SpriteImportMode.Single;
            textureImporter.spritePixelsPerUnit = 100;// Adjust this value as needed

            // Apply the changes
            textureImporter.SaveAndReimport();
        }
    }
}