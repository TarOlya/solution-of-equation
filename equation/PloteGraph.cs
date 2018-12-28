using System;
using equation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    class PloteGraph
    {
        private double _xMin;
        private double _xMax;
        private double _yMin;
        private double _yMax;

        private Equation Variables;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphs;

        public PloteGraph(Equation eq, System.Windows.Forms.DataVisualization.Charting.Chart Graphs)
        {
            this.Graphs = Graphs;

            Variables = eq;
        }

        public void SizeX(double xMin, double xMax)
        {
            _xMin = xMin;
            _xMax = xMax;
            
            Graphs.ChartAreas[0].AxisX.Minimum = _xMin;
            Graphs.ChartAreas[0].AxisX.Maximum = _xMax;
            Graphs.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Graphs.ChartAreas[0].AxisY.Maximum = Double.NaN;

            CreateGraphics();
        }

        public void SizeY(double xMin, double xMax, double yMin, double yMax)
        {
            _xMin = xMin;
            _xMax = xMax;

            _yMin = yMin;
            _yMax = yMax;
            
            Graphs.ChartAreas[0].AxisX.Minimum = _xMin;
            Graphs.ChartAreas[0].AxisX.Maximum = _xMax;
            Graphs.ChartAreas[0].AxisY.Minimum = _yMin;
            Graphs.ChartAreas[0].AxisY.Maximum = _yMax;

            CreateGraphics();
        }

        public void SizeXandY(double xMin, double xMax, double yMin, double yMax)
        {
            _xMin = xMin;
            _xMax = xMax;

            _yMin = yMin;
            _yMax = yMax;
            
            Graphs.ChartAreas[0].AxisX.Minimum = _xMin;
            Graphs.ChartAreas[0].AxisX.Maximum = _xMax;
            Graphs.ChartAreas[0].AxisY.Minimum = _yMin;
            Graphs.ChartAreas[0].AxisY.Maximum = _yMax;

            CreateGraphics();
        }

        public void AutoSize(double xMin, double xMax)
        {
            _xMin = xMin;
            _xMax = xMax;
            
            Graphs.ChartAreas[0].AxisX.Minimum = _xMin;
            Graphs.ChartAreas[0].AxisX.Maximum = _xMax;
            Graphs.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Graphs.ChartAreas[0].AxisY.Maximum = Double.NaN;

            CreateGraphics();
        }

        public Complex DegreeEquation(Complex x)
        {
            Complex valueY = 0;
            valueY = Variables.FunctionValue(x);
            return valueY;
        }
        

        private void CreateGraphics()
        {
            double Diapasone = _xMax - _xMin;
            double Step = Math.Abs(Diapasone / 10);

            int count = (int)Math.Ceiling((_xMax - _xMin) / Step) + 1;

            double[] x = new double[count];
            double[] y1 = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = _xMin + Step * i;
                y1[i] = DegreeEquation(x[i])._real;
            }
            
            Graphs.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            Graphs.Series[0].Points.DataBindXY(x, y1);
        }
    }
}

