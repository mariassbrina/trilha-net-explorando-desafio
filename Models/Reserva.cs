namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        private const int DiasParaDesconto = 10;
        private const decimal PercentualDesconto = 0.10m;

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes == null)
                throw new ArgumentNullException(nameof(hospedes), "A lista de hóspedes não pode ser nula.");

            if (Suite == null)
                throw new InvalidOperationException("Cadastre a suíte antes de cadastrar os hóspedes.");

            // Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException(
                    $"A suíte {Suite.TipoSuite} comporta {Suite.Capacidade} hóspede(s), mas foram informados {hospedes.Count}.",
                    nameof(hospedes));
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("Cadastre a suíte antes de calcular o valor.");

            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= DiasParaDesconto)
            {
                valor -= valor * PercentualDesconto;
            }

            return valor;
        }
    }
}
