using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class ApplicationTitle : Base, ITitle
    {
        private string title = "Application from ApplicationTitle";

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChange(nameof(Title));
                }
            }
        }
    }
}
