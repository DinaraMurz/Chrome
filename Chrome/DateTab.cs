using System;

namespace Chrome
{
    public class DateTab : Tab
    {
        public DateTab()
        {
            Name = DateTime.Now.ToString();
        }
    }
}