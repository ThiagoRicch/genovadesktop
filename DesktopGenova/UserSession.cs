using System;

namespace DesktopGenova
{
    public static class UserSession
    {
        // Aqui ficam as informações do usuário logado
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string Sobrenome { get; set; }
        public static string Email { get; set; }

        // Para saber se alguém está logado
        public static bool IsLoggedIn => Id != 0;

        // Método auxiliar para limpar a sessão
        public static void Logout()
        {
            Id = 0;
            Nome = null;
            Sobrenome = null;
            Email = null;
        }
    }
}
