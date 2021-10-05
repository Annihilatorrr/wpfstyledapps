using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathStat.App.Models;
using MathStat.Infrastructure;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MathStat.App.ViewModels
{
    class MainViewModel: ObservableObject
    {
        private readonly IDistributionService _distributionService;
        private List<Section> _sections;

        public List<Section> Sections
        {
            get => _sections;
            set => SetProperty(ref _sections, value);
        }

        public MainViewModel(IDistributionService distributionService)
        {
            _distributionService = distributionService;
            Sections = new List<Section>();
            Sections.Add(new Section(){Name = "Distributions"});
        }
    }
}
