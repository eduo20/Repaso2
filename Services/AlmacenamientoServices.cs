using Repaso2.Models;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Repaso2.Services


{
    public class LibroService
    {
        private readonly string _jsonFile = "Libros.json";

        public List<Libros> ObtenerLibros()
        {
            if (!File.Exists(_jsonFile)) return new List<Libros>();
            try
            {
                var json = File.ReadAllText(_jsonFile);
                return JsonSerializer.Deserialize<List<Libros>>(json) ?? new List<Libros>();
            }
            catch { return new List<Libros>(); }
        }

        public void GuardarLibro(Libros libro)
        {
            var lista = ObtenerLibros();
            lista.Add(libro);
            File.WriteAllText(_jsonFile, JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true }));
        }
    }

    public class ElectronicoService
    {
        private readonly string _jsonFile = "Electronicos.json";

        public List<Electronicos> ObtenerElectronicos()
        {
            if (!File.Exists(_jsonFile)) return new List<Electronicos>();
            try
            {
                var json = File.ReadAllText(_jsonFile);
                return JsonSerializer.Deserialize<List<Electronicos>>(json) ?? new List<Electronicos>();
            }
            catch { return new List<Electronicos>(); }
        }

        public void GuardarElectronico(Electronicos electronico)
        {
            var lista = ObtenerElectronicos();
            lista.Add(electronico);
            File.WriteAllText(_jsonFile, JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true }));
        }
    }

    public class AlimentoService
    {
        private readonly string _jsonFile = "Alimentos.json";

        public List<Alimentos> ObtenerAlimentos()
        {
            if (!File.Exists(_jsonFile)) return new List<Alimentos>();
            try
            {
                var json = File.ReadAllText(_jsonFile);
                return JsonSerializer.Deserialize<List<Alimentos>>(json) ?? new List<Alimentos>();
            }
            catch { return new List<Alimentos>(); }
        }

        public void GuardarAlimento(Alimentos alimento)
        {
            var lista = ObtenerAlimentos();
            lista.Add(alimento);
            File.WriteAllText(_jsonFile, JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}