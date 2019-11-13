using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro.Core.Services
{
    public class UserNotificationService : IUserNotificationService
    {
        public event EventHandler<string> Notify = delegate { };

        public Task Show(string message)
        {
            //object inAppNotificationWithButtonsTemplate = null;
            //bool? isTemplatePresent = _resources?.TryGetValue("InAppNotificationWithButtonsTemplate", out inAppNotificationWithButtonsTemplate);

            //if (isTemplatePresent == true && inAppNotificationWithButtonsTemplate is DataTemplate template)
            //{
            //    ExampleInAppNotification.Show(template, 0);
            //}

            Notify.Invoke(this, message);

            return Task.CompletedTask;
        }
    }
}