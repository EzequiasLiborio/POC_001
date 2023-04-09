using System.Text.Json.Serialization;

namespace Faturamento.Model
{
    internal class FaturamentoDiario
    {
        [JsonPropertyName("dia")]
        public int Dia { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }
}
