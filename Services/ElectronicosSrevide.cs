using System.Text.Json;
using Repaso2.Models;

namespace Repaso2.Services
{
    public class ElectronicosSrevide
    {
        private readonly string _ElectronicosJson = "Electronicos.json";

        public List<Electronicos> NuevoElectronic()
        {
            if(!File.Exists(_ElectronicosJson))
            return new List<Electronicos>();

            try
            {
                var leerjosn = File.ReadAllText(_ElectronicosJson);
                return JsonSerializer.Deserialize<List<Electronicos>>(leerjosn) ?? new List<Electronicos>();
            }
            catch (JsonException) {
                return new List<Electronicos>();
            }
        }
    }
}
