using Models;
using Prism.Commands;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Visuals
{
    public class ShapeVM : INotifyPropertyChanged
    {
        public ShapeVM()
        {
            saveShapeCommand = new DelegateCommand(SaveShape);
        }

        private void SaveShape()
        {
            var shapeSaver = new ShapeSaver();

            var shape = new Shape(ShapeName, ShapeColor, ShapeSize, ShapeX, ShapeY);

            shapeSaver.Save(shape);
        }

        private string shapeName;
        public string ShapeName
        {
            get { return shapeName; }
            set
            {
                shapeName = value;
                OnPropertyChanged(nameof(ShapeName));
            }
        }

        private string shapeColor;
        public string ShapeColor
        {
            get { return shapeColor; }
            set
            {
                shapeColor = value;
                OnPropertyChanged(nameof(ShapeColor));
            }
        }

        private double shapeSize;
        public double ShapeSize
        {
            get { return shapeSize; }
            set
            {
                shapeSize = value;
                OnPropertyChanged(nameof(ShapeSize));
            }
        }

        private int shapeX;
        public int ShapeX
        {
            get { return shapeX; }
            set
            {
                shapeX = value;
                OnPropertyChanged(nameof(ShapeX));
            }
        }

        private int shapeY;
        public int ShapeY
        {
            get { return shapeY; }
            set
            {
                shapeY = value;
                OnPropertyChanged(nameof(ShapeY));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private DelegateCommand saveShapeCommand;
        public ICommand SaveShapeCommand
        {
            get { return saveShapeCommand; }
        }

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
