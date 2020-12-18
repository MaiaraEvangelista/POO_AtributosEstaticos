namespace Atributos_estáticos
{
    public static class Conversor
    {
        public static float cotacaoDolar = 5.10f;

        public static float ConverterDolarParaReal(float valorEmDolar){
                return valorEmDolar * cotacaoDolar;
        }

        public static float ConverterRealParaDolar(float valorEmReal){
            return valorEmReal / cotacaoDolar;
        }

        //Acrescentando outra transformação 

        public static float cotacaoEuro = 6.25f;

        public static float ConverterEuroParaReal(float valorEmEuro){
            return valorEmEuro * cotacaoEuro;
        }

        public static float ConverterRealParaEuro (float valorEmReal){
            return valorEmReal / cotacaoEuro;
        }
    }
}