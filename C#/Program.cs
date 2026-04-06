using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;
namespace WelcomeExtended
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                var user = new User
                {
                    _names = "John Smith",
                    _password = "password123",
                    _role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                MainWindow w = new MainWindow();

                w.DisplayUser();
                w.ShowDialog();

                w.DisplayError();

            }
            catch (Exception e) {
                var log = new ActionOnError(Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}
