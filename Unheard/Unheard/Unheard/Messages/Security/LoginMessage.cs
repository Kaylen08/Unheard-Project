using Prism.Events;
using Appointments.Model.Security;

namespace Appointments.Messages.Security
{
    public class LoginMessage : PubSubEvent<UserProfile>
    {
    }
}
