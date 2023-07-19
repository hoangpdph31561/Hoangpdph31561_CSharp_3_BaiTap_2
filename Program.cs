using Hoangpdph31561_CSharp_3_BaiTap_2.View;

namespace Hoangpdph31561_CSharp_3_BaiTap_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=QUANLYSACH_XUONG_LV1;Integrated Security=True
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new QuanLySach());
        }
    }
}