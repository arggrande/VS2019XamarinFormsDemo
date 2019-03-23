using System.IO;
using System.Reflection;

namespace Demo.Services
{
    public static class EmbeddedResource
    {

        public static string Get(string resourceName)
        {
            var assembly = typeof(EmbeddedResource).GetTypeInfo().Assembly;

            // This shows the available items.
            string[] resources = assembly.GetManifestResourceNames();

            var stream = assembly.GetManifestResourceStream($"Demo.{resourceName}");

            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}