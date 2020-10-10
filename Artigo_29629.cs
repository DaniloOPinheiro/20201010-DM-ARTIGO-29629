using System;
using _20201010_DM_ARTIGO_29629.Enums;

namespace _20201010_DM_ARTIGO_29629
{
    public class Artigo_29629
    {
        public int numero;
        public DateTime datahora;
        public int situacao;

        public static void GetArtigo_29629()
        {
            Artigo_29629 artigo = new Artigo_29629();

            artigo.numero = 1;
            artigo.datahora = DateTime.Now;
            artigo.situacao = (int) ESituacao.Fatura;

            Console.WriteLine(
                artigo.numero.ToString() + " - " +
                artigo.datahora.ToString() + " - " +
                artigo.situacao.ToString());
        }
    }
}