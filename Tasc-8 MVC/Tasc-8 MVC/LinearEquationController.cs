using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasc_8_MVC
{
    public class LinearEquationController
    {
        // Расчитываем значение и возвращаем результат 
        private LinearEquationModel _equation;

        public LinearEquationController()
        {
            _equation = new LinearEquationModel();
        }

        public double CalculateY(double x)
        {
            return (_equation.Slope * x) + _equation.YIntercept;
        }

        public void SetSlope(double slope)
        {
            _equation.Slope = slope;
        }

        public void SetYIntercept(double yIntercept)
        {
            _equation.YIntercept = yIntercept;
        }
    }
}
