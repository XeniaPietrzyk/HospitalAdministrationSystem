using Model.Helpers;

namespace Model.Login
{
    public class LoginValidation
    {
        public Employee ValidateUser(Context context, string login, string password)
        {
            var exist = context.LoginPassword.TryGetValue(login, out var e);
            Employee employee = null;
            if (exist)
            {
                foreach (var item in context.Admins)
                {
                    if (item.UserName == login)
                    {
                        employee = item;
                        return employee;
                    }
                }
                foreach (var item in context.Nurses)
                {
                    if (item.UserName == login)
                    {
                        employee = item;
                        return employee;
                    }
                }
                foreach (var item in context.Physicians)
                {
                    if (item.UserName == login)
                    {
                        employee = item;
                        return employee;
                    }
                }
            }
            return employee;
        }

        public bool ValidatePassword(Employee employee, string password)
        {
            if (employee.Password == password)
            {
                return true;
            }
            else return false;
        }
    }
}
