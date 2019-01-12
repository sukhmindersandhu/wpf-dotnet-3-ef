using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class MainViewModel : Base
    {
        private readonly TestDataContext dataContext;

        private readonly IServiceProvider serviceProvider;

        public MainViewModel(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.dataContext = serviceProvider.GetService<TestDataContext>();
            ITitle mainTitle = serviceProvider.GetService<ITitle>();
            Title = mainTitle.Title;
        }

        private string title = "Dependency Injection Application";

        public string Title
        {
            get { return title; }
            set
            {
                title = dataContext.data.FirstOrDefault().Name;
                OnPropertyChange(nameof(Title));
            }
        }
    }
}
