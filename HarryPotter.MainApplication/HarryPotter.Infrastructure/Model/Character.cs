using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Infrastructure.Model
{
    public class Character :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        private string? name;
        private string? gender;


        public int Id { get; set; }
        public string? Name { get => name; set => name = value; }
        public string? Species { get; set; }
        public string? Gender
        {
            get => gender;
            set
            {
                gender = value;
                if (gender != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
                }
            }
        }
        public string? House { get; set; }
        public string? DateOfBirth { get; set; }
        public int? YearOfBirth { get; set; }
        public bool Wizard { get; set; }
        public string? Ancestry { get; set; }
        public string? EyeColour { get; set; }
        public string? HairColour { get; set; }
        public MagicWand? Wand { get; set; }
        public string? Patronus { get; set; }
        public bool? HogwartsStudent { get; set; }
        public bool? HogwartsStaff { get; set; }
        public string? Actor { get; set; }
        public bool? Alive { get; set; }

        public string? Image { get; set; }

    }
}