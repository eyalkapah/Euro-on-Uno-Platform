using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.Core.Services
{
    public interface IUserNotificationService
    {
        event EventHandler<string> Notify;

        Task Show(string message);
    }
}