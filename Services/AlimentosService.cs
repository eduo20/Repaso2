using Repaso2.Models;

using System.Text.Json;

namespace Repaso2.Services
{
    public class AlimentosService
    {
        private readonly string _AlimentosJson = "Alimentos.json";

        public List<Alimentos> ObtenerAlimentos()
        {
            if (!File.Exists(_AlimentosJson))

                return new List<Alimentos>();

            try
            {
                var alimentosJson = File.ReadAllText(_AlimentosJson);
                return JsonSerializer.Deserialize<List<Alimentos>>(alimentosJson) ?? new List<Alimentos>();
            }
            catch(JsonException) 
            {
                return new List<Alimentos>();
            }
        }  

        public void GuardadAlimentos(Alimentos alimento)
        {
            {
                List<Alimentos> alimentosList = ObtenerAlimentos();
                alimentosList.Add(alimento);
                var opcionesJson = new JsonSerializerOptions { WriteIndented = true };
                var nuevoAlimentosJson = JsonSerializer.Serialize(alimentosList, opcionesJson);
                File.WriteAllText(_AlimentosJson, nuevoAlimentosJson);
            }
        }
        
    }
}
