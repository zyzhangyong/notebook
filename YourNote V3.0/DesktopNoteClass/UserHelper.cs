using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopNote.DesktopNoteClass
{
    class UserHelper
    {
        public static string user = "";
        public static UserType userType;
    }
    public enum UserType
    {
        admin,
        user
    }
}
