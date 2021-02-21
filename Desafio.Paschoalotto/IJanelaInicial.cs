using MahApps.Metro.Controls;
using System;
using System.Windows.Controls;

namespace Desafio.Paschoalotto
{
    public interface IJanelaInicial
    {
        void ShowAviso(string mensagem);

        void Carregando(bool Carregando);

        void GravarErro(Exception ex);

        void AbrirPopup(string Titulo, UserControl UC);

        void FecharPopup(UserControl UC);
    }
}