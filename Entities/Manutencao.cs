using VoeAirlines.Entities.Enums;

namespace VoeAirlines.Entities 
{
    public class Manutencao
    {
        public Manutencao(DateTime dataHora, string observacao, TipoManutencao tipo, int aeronaveId)
        {
            DataHora = dataHora;
            Observacao = observacao;
            Tipo = tipo;
            AeronaveId = aeronaveId;
        }

        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Observacao { get; set; }
        public TipoManutencao Tipo { get; set; }
        public int AeronaveId { get; set; }
        public Aeronave Aeronave { get; set; }=null!;
    }
}