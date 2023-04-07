using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tasc2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brush _brush = Brushes.Black;
        private double _size = 5;
        private bool _isDrawing = false;
        private Point _lastPoint;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InkCanvas inkCanvas1 = new InkCanvas();
            var inkCanvas = inkCanvas1;
            var colorString = colorComboBox.SelectedValue as string;
            if (!string.IsNullOrEmpty(colorString))
            {
                var color = ColorConverter.ConvertFromString(colorString) as Color?;
                if (color.HasValue)
                {
                    _brush = new SolidColorBrush(color.Value);
                    inkCanvas.DefaultDrawingAttributes.Color = color.Value;
                }
            }
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _size = sizeSlider.Value;
        }

        private void ModeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (drawModeRadioButton.IsChecked == true)
            {
                _isDrawing = true;
            }
            else
            {
                _isDrawing = false;
            }
        }

        private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_isDrawing)
            {
                _lastPoint = e.GetPosition(drawingCanvas);
            }
        }

        private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing && e.LeftButton == MouseButtonState.Pressed)
            {
                var currentPoint = e.GetPosition(drawingCanvas);
                var line = new Line
                {
                    X1 = _lastPoint.X,
                    Y1 = _lastPoint.Y,
                    X2 = currentPoint.X,
                    Y2 = currentPoint.Y,
                    Stroke = _brush,
                    StrokeThickness = _size
                };
                _lastPoint = currentPoint;
                drawingCanvas.Children.Add(line);
            }
        }

        private void DrawingCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _isDrawing = false;
        }
    }
}
