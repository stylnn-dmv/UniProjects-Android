using System.Configuration;
using System.Data;
using System.Windows;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;


namespace Welcome
{
  
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            User obj1 = new User("Ivan Todorov","Pass1234","ivantd@gmail.com",Others.UserRolesEnum.STUDENT,0);
            UserViewModel obj2 = new UserViewModel(obj1);
            MainWindow obj3 = new MainWindow(obj2);
            obj3.DisplayUser();
            obj3.Show();
            

        }
    }

}
