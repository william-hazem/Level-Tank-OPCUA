using System.Runtime.InteropServices;
using Opc.Ua;
using Opc.Ua.Configuration;
using TankClient;

namespace TankClientUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {     
            try
            {
                ApplicationConfiguration.Initialize();

                Application.Run(new ClientScreen());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + '|' +e.InnerException);
            }


            
        }
    }
}