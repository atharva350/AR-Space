using UnityEngine;
using TMPro;
using UnityEditor;

public class WobblyText : MonoBehaviour
{
    // Reference to the TMP_Text component
    public TMP_Text textComponent;

    void Start()
    {
        // Check if the text component is assigned
        if (textComponent == null)
        {
            Debug.LogWarning("Text component is not assigned.", this);
            return;
        }
    }

    void Update()
    {
        // Ensure the text component is assigned
        if (textComponent == null)
            return;

        // Apply wobbling effect to the text
        ApplyWobbleEffect();
    }

    void ApplyWobbleEffect()
    {
        // Force mesh update to get accurate text information
        textComponent.ForceMeshUpdate();

        // Get text info
        var textInfo = textComponent.textInfo;

        // Iterate through each character
        for (int i = 0; i < textInfo.characterCount; ++i)
        {
            var charInfo = textInfo.characterInfo[i];

            // Skip invisible characters
            if (!charInfo.isVisible)
                continue;

            // Get vertices of the character's mesh
            var verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

            // Modify vertices to create wobbling effect
            for (int j = 0; j < 4; ++j)
            {
                var orig = verts[charInfo.vertexIndex + j];
                verts[charInfo.vertexIndex + j] = orig + new Vector3(0, Mathf.Sin(Time.time * 2f + orig.x * 0.01f) * 10f, 0);
            }
        }

        // Update the geometry of the text component
        for (int i = 0; i < textInfo.meshInfo.Length; ++i)
        {
            var meshInfo = textInfo.meshInfo[i];
            meshInfo.mesh.vertices = meshInfo.vertices;
            textComponent.UpdateGeometry(meshInfo.mesh, i);
        }
    }
}
