using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DESGLOSADOR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {

			int cant, centa, D200, D100, D50, D20, D10, D5, D1, M50, M25, M10, M5, M1;
			cant = D200 = D100 = D50 = D20 = D10 = D5 = D1 = M50 = M25 = M10 = M5 = M1 = 0;
			string dinero = DATO1.Text;


			double pacentavo;

			if (dinero == "")
			{
				dinero = "0";
			}

			pacentavo = Convert.ToDouble(dinero);

			cant = Convert.ToInt32(Math.Truncate(pacentavo));
			pacentavo = (pacentavo - cant) * 100;
			centa = Convert.ToInt32(pacentavo);
			
		

			if (cant >= 200)
			{
				D200 = (cant / 200);
				cant = cant - (D200 * 200);

			}

			if (cant >= 100)
			{
				D100 = (cant / 100);
				cant = cant - (D100 * 100);

			}

			if (cant >= 50)
			{
				D50 = (cant / 50);
				cant = cant - (D50 * 50);

			}

			if (cant >= 20)
			{
				D20 = (cant / 20);
				cant = cant - (D20 * 20);

			}
			if (cant >= 10)
			{
				D10 = (cant / 10);
				cant = cant - (D10 * 10);

			}
			if (cant >= 5)
			{
				D5 = (cant / 5);
				cant = cant - (D5 * 5);
			}

			if (cant >= 1)
			{
				D1 = (cant / 1);
				cant = cant - (D1 * 1);

			}


			if (centa >= 50)
			{
				M50 = (centa / 50);
				centa = centa - (M50 * 50);

			}

			if (centa >= 25)
			{
				M25 = (centa / 25);
				centa = centa - (M25 * 25);
			}

			if (centa >= 10)
			{
				M10 = (centa / 10);
				centa = centa - (M10 * 10);
			}

			if (centa >= 5)
			{
				M5 = (centa / 5);
				centa = centa - (M5 * 5);
			}

			if (centa >= 1)
			{
				M1 = (centa / 1);
				centa = centa - (M1 * 1);
			}



			
			RESULTADO.Text = $" Billetes de 200: {D200}" + $"\n Billetes de 100: {D100}" + $"\n Billetes de   50: {D50}"
				+ $"\n Billetes de   20: {D20}" + $"\n Billetes de   10: {D10}" + $"\n Billetes de   05: {D5}" + $"\n Billetes de   01: {D1}\n"
				+ $"\n Monedas de 50: {M50}" + $"\n Monedas de 25: {M25}" + $"\n Monedas de 10: {M10}" + $"\n Monedas de 05: {M5}" + $"\n Monedas de 01: {M1}";




		}
    }
}