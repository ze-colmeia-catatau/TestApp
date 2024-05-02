namespace GestaoEquipamentos.ConsoleApp
{
    public static class GeradorId
    {
        private static int contadorIdsEquipamentos = 0;

        public static int GerarIdEquipamento()
        {
            return ++contadorIdsEquipamentos;
        }
    }
}
