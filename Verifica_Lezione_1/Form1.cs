using System;

namespace Verifica_Lezione_1
{
    public partial class Form1 : Form
    {
        int[] vett = new int[]{ 2, 5, 7, 3 };

        public Form1()
        {
            InitializeComponent();

            var fatt = fattorialeRicorsivo(vett[1]);
            var pot = potenza(vett[1], 3);
        }        

        int fattorialeRicorsivo(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * fattorialeRicorsivo(num - 1);
        }


        int potenza(int baseNum, int exp)
        {
            if (exp == 0)
                return 1;
            else
                return baseNum * potenza(baseNum, exp - 1);
        }


        // baseNum = 5, exp = 3

        // 5 * 25

        // baseNum = 5, exp = 2

        //          5 * 5

        // baseNum = 5, exp = 1

        //                   5 * 1

        // baseNum = 5, exp = 0

        //                            1















        // num = 5

        // 5 * 24
        //     4 * 6
        //          3 * 2
        //              2 * 1
        //                      1















        // 5 * fun(4)
        //     4 * fun(3)
        //          3 * fun(2)
        //              2 * fun(1)
        //                      1

    }
}
