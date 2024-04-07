using Resize.Domain;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Resize.Application
{
    public class ResizeApplication : IResizeApplication
    {
        private readonly string _jsonFilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName, Path.Combine("Resize.Data", "dimensions.json"));
        //private readonly string _jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/dimensions.json");
        public async Task<Dimensions> InitialDimentions()
        {
            try
            {
                // Read JSON file and deserialize dimensions
                using (StreamReader reader = new StreamReader(_jsonFilePath))
                {
                    string json = await reader.ReadToEndAsync();
                    Dimensions dimensions = JsonConvert.DeserializeObject<Dimensions>(json);
                    return dimensions;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Dimensions> UpdateDimentions(Dimensions info)
        {
            try
            {
                // Serialize updated dimensions and write to JSON file
                string json = JsonConvert.SerializeObject(info);
                await File.WriteAllTextAsync(_jsonFilePath, json);
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
