namespace Converter
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            string rna = dna.Replace("T", "U");
            return rna;
        }
    }
}