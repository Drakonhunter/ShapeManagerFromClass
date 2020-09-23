using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visuals
{
    public class ShapeVM : INotifyPropertyChanged
    {
        private string shapeName;
        public string ShapeName
        {
            get { return shapeName; }
            set
            {
                shapeName = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if(PropertyChanged == null)
            {
                return;
            }

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
