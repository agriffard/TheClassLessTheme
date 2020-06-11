using OrchardCore.ResourceManagement;

namespace TheClassLessTheme.OrchardCore
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("marx")
                .SetUrl("~/TheClassLessTheme/css/marx.min.css", "~/TheClassLessTheme/css/marx.css")
                .SetVersion("3.0.7");
        }
    }
}
