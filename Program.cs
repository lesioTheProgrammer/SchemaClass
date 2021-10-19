using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System.IO;
using System.Threading.Tasks;

namespace SchemaClass
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string exactFile = "ItemPrice.json"; // json file extension

            var schema = await ReadFromFile(exactFile);
            var generator = new CSharpGenerator(schema);
            var file = generator.GenerateFile();

            // modify ItemPrice.txt to save as another file
            File.WriteAllText(
                "C:\\Repository\\LesioTools\\Schema Class Generator\\SchemaClass\\Schemas\\ItemPrice.txt", file);
        }

        public static async Task<JsonSchema> ReadFromFile(string file)
        {
            var path = $"C:\\Repository\\LesioTools\\Schema Class Generator\\SchemaClass\\Schemas\\{file}";

            return
                await JsonSchema.FromFileAsync(path);
        }
    }
}
