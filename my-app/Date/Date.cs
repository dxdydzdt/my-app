using System;
using System.Collections.Generic;
using System.Text;

namespace my_app.Date
{
    public sealed class Date
    {
        private static Date m_Instance;

        public static Date getInstance()
        {
            if(m_Instance == null)
                m_Instance = new Date();

            return m_Instance;
        }

        public string getCurrentDate(string? format)
        {
            return DateTime.Now.ToString(format);
        }
    }
}
