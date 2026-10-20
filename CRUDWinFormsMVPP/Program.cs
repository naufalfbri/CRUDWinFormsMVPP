using CRUDWinFormsMVPP._Repositories;
using CRUDWinFormsMVPP.Models;
using CRUDWinFormsMVPP.Presenters;
using CRUDWinFormsMVPP.Views;
using MvpCrudApp.Models;
using System;
using System.Windows.Forms;

namespace CRUDWinFormsMVPP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string connectionString = "Server=localhost;Port=3306;Database=veterinarydb;Uid=root;Pwd=;";

            IPetView view = new PetView();
            IPetRepository repository = new PetRepository(connectionString);
            new PetPresenter(view, repository);

            Application.Run((Form)view);
        }
    }
}