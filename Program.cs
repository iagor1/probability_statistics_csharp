namespace probability;
class Program
{
    static void Main(string[] args)
    {
        
        List<int> lista_xifi = new List<int>();
        List<int> lista_xi2fi = new List<int>();
        List<int> lista_fi = new List<int>();

        Console.WriteLine("Digite quantos numeros deseja calcular :");
        var n = int.Parse(Console.ReadLine());
        for(int c =0; c < n ; c++){
            Console.Write("Digite o valor de xi :");
            int xi = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor fi :");
            int fi = int.Parse(Console.ReadLine());

            int xifi = xi * fi;
            int xi2fi = (xi*xi)*fi;
            lista_xifi.Add(xifi);
            lista_xi2fi.Add(xi2fi);
            lista_fi.Add(fi);
        }
        foreach (var valores_xi2fi in lista_xi2fi)
        {
            Console.Write("valores xi2fi : ");
            Console.Write(valores_xi2fi);
            Console.WriteLine("");
        }
        
        foreach (var valores_xifi in lista_xifi)
        {
            Console.Write("valores xifi : ");
            Console.Write(valores_xifi);
            Console.WriteLine("");
        }

        Console.Write("O somatorio de xifi = ");
        Console.WriteLine(lista_xifi.Sum());
        Console.Write("O somatorio de xi2fi = ");
        Console.WriteLine(lista_xi2fi.Sum());
        Console.Write("O somatorio de fi(frequencias) = ");
        Console.WriteLine(lista_fi.Sum());
        var media = Media(lista_xifi.Sum(),lista_fi.Sum());
        var variance = Variancia(lista_xifi.Sum(),lista_fi.Sum(),lista_xi2fi.Sum());
        var desvio_padrao = Math.Sqrt(variance);
        Console.WriteLine("O desvio padrão é:"+desvio_padrao);
        CoeficienteDeVariacao(desvio_padrao,media);
    }

   public static double Media(double somatorioxifi, double frequencias)
   {
        double media = somatorioxifi/frequencias;
        Console.Write("a media é = ");
        Console.WriteLine(media);
        return media;
        //double or float
   }
    public static double Variancia(double somatorioxifi, double frequencia,double somatorioxi2fi)
   {
        double pow_xifi = Math.Pow(somatorioxifi,2);
        double stepOne = pow_xifi/frequencia;
        double stepTwo = somatorioxi2fi - stepOne;
        double stepThre = stepTwo/(frequencia - 1);
        Console.Write("A variancia é =");
        Console.WriteLine(stepThre);
        return stepThre;
   }
    public static double CoeficienteDeVariacao(double desvio_padrao, double media )
    {
        double calc = (desvio_padrao/media)*100;
        Console.Write("o coeficiente de variacao em % é =");
        Console.WriteLine(calc);
        return calc;
    }
}
