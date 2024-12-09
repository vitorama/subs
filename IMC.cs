{
    public class IMC
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double ValorIMC => Peso / (Altura * Altura);
    
    }
}
