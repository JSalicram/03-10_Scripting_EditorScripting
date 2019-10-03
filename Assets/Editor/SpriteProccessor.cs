using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpriteProccessor : AssetPostprocessor
{
    private void OnPostprocessTexture(Texture2D texture)
    {
        Debug.Log("Texture imported");
        string lowerCaseAssetPath = assetPath.ToLower();
        bool isInSpriteDirectory = lowerCaseAssetPath.IndexOf("/sprites/") != -1;

        if (isInSpriteDirectory)
        {
            Debug.Log("Sprite in directory");
            TextureImporter textureImporter = (TextureImporter)assetImporter;
            textureImporter.textureType = TextureImporterType.Sprite;

            //start of assessment
            textureImporter.maxTextureSize = 1024;
            textureImporter.crunchedCompression = true;
            textureImporter.textureCompression = TextureImporterCompression.CompressedHQ;
            textureImporter.spritePixelsPerUnit = 50;

            /*
            TextureImporterPlatformSettings textureImporterPlatform = TextureImporterPlatformSettings;
            textureImporterPlatform.resizeAlgorithm = TextureResizeAlgorithm.Bilinear;*/
        }
    }
}
