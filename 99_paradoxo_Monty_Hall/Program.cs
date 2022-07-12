

using System.Globalization;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n=== O paradoxo de Monty Hall ===");
            System.Console.WriteLine(   "O problema foi apresentado no programa de televisão Let’s Make a Deal nos Estados Unidos. O paradoxo " + 
                                        "de Monty Hall considera que existem três portas, atrás de uma existe um prêmio e, atrás das outras du" + 
                                        "as não existe nada. Na primeira etapa uma pessoa escolhe uma porta (esta ainda não é aberta), após is" + 
                                        "so uma outra porta (que não foi a escolhida) é aberta e é revelado que não contém nada. Neste momento" + 
                                        ", se tem 2 duas portas fechadas (uma porta contem o prêmio e a outra porta não contem nada). Então, a" + 
                                        "pós esta etapa temos duas portas fechadas e a pessoa tem a possibilidade de manter a sua escolha inic" + 
                                        "ial ou pode optar em trocar de porta. Então, a pergunta é: A melhor opção seria ficar com a porta ini" + 
                                        "cialmente escolhida ou trocar para a porta que sobrou?" + 
                                        "\n");

            int qtdRodadas = 1000000;
            double VITORIAS = 0;
            double DERROTAS = 0;

            System.Console.WriteLine("\n== Calcula quando o jogador escolhe uma porta e fica com ela até o fim do jogo!");
            for (int i = 1; i <= qtdRodadas; i++)
            {
                List<Porta> portas = GerarPortas();
                //ListarPortas(portas);

                if ( Venceu(portas) )
                    VITORIAS++;
                else
                    DERROTAS++;
            }
            double percentVitoria = (VITORIAS / (VITORIAS+DERROTAS)) * 100;
            System.Console.WriteLine(   "Venceu " + VITORIAS + " de " + (VITORIAS+DERROTAS) + 
                                        ", percentual de vitória de " + percentVitoria + " %");



            System.Console.WriteLine(   "\n== Calcula quando o jogador escolhe uma porta, o programa elimida uma das portas restantes" + 
                                        " e então o jogador troca de porta sempre");
            VITORIAS = 0;
            DERROTAS = 0;

            for (int i = 1; i <= qtdRodadas; i++)
            {
                List<Porta> portas = GerarPortas();
                RemoverUmaPorta(portas);
                EscolheOutraPorta(portas);

                if ( Venceu(portas) )
                    VITORIAS++;
                else
                    DERROTAS++;
            }
            percentVitoria = (VITORIAS / (VITORIAS+DERROTAS)) * 100;
            System.Console.WriteLine(   "Venceu " + VITORIAS + " de " + (VITORIAS+DERROTAS) + 
                                        ", percentual de vitória de " + percentVitoria + " %");
            
        }


        public static List<Porta> GerarPortas()
        {
            int portaPremiada = new Random().Next(0, 3);    // entre 0 e 2
            int portaEscolhida = new Random().Next(0, 3);   // entre 0 e 2
            // System.Console.WriteLine(   "Premiada = " + portaPremiada +
            //                             ", Escolhida = " + portaEscolhida);

            List<Porta> portas = new List<Porta>();
            for (int i = 0; i <= 2; i++)
            {
                int nrPorta = i+1;
                Porta porta = new Porta("Porta nr " + nrPorta);

                if (i == portaEscolhida)
                    porta.Escolhida = true;
                
                if (i == portaPremiada)
                    porta.Premiada = true;

                portas.Add(porta);
            }

            return portas;
        }


        public static void ListarPortas(List<Porta> portas)
        {
            foreach (var p in portas)
                System.Console.WriteLine(p);
        }
    

        public static bool Venceu(List<Porta> portas)
        {
            bool ret = false;
            foreach (Porta p in portas)
            {
                if (p.Valida)
                    if (p.Escolhida && p.Premiada)
                        ret = true;
            }

            return ret;
        }


        public static List<Porta> RemoverUmaPorta(List<Porta> portas)
        {
            foreach (Porta p in portas)
            {
                if (p.Premiada == false && p.Escolhida == false)
                {
                    p.Valida = false;
                    break;
                }
            }

            return portas;
        }


        public static void EscolheOutraPorta(List<Porta> portas)
        {
            foreach (Porta p in portas)
            {
                if (p.Valida)
                {
                    if (p.Escolhida)
                        p.Escolhida = false;
                    else
                        p.Escolhida = true;
                }
            }
        }

    }
}