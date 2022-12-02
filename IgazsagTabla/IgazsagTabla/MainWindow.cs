using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgazsagTabla
{
    public partial class MainWindow : Form
    {
        private BoolExpr expression1;
        private bool error1 = false;
        private bool errors = false;
        


        public MainWindow()
        {
            InitializeComponent();
            ErrorMsgLbl.Text = "";
            expression1 = new BoolExpr("");
        }

        // ha változik a bemenet
        private void Input1_TextChanged(object sender, EventArgs e)
        {
            checkInputs();
        }

        // bevitel közben ellenőrzi a függvény helyességét
        private void checkInputs()
        {
            if (inLogFüg.Text != "") {
                try {
                    expression1 = new BoolExpr(inLogFüg.Text);
                    expression1.Solve();
                    error1 = false;
                } catch (Exception ex) {
                    ErrorMsgLbl.Text = "Rossz függvény lett megadva: " + ex.Message;
                    error1 = true;
                }
            } else {
                error1 = false;
                
                }

            errors = (error1) ? true : false;
            if (!errors) ErrorMsgLbl.Text = "";
            }


        // start gomb leütése után
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!validateInputs()) return;

            // táblázat törlése:
            igazTblView.Columns.Clear();
            igazTblView.Items.Clear();

            List<char> boolVars;

            boolVars = expression1.GetBoolVars();

            bool[,] inputTable = GenInputTable(boolVars.Count);

            foreach (char c in boolVars) {
                igazTblView.Columns.Add(c.ToString());
            }

            // megoldás:
            bool[] bemenet = new bool[inputTable.GetLength(0)];
            for (int i = 0; i < inputTable.GetLength(0); i++) {
                for (int j = 0; j < inputTable.GetLength(1); j++) {
                    expression1.SetValue(boolVars[j], inputTable[i, j]);
                }
                bemenet[i] = expression1.Solve();
            }

            igazTblView.Columns.Add("Y");
            for (int i = 0; i < inputTable.GetLength(0); i++) {
                ListViewItem L = igazTblView.Items.Add(getBoolStr(inputTable[i, 0]));
                for (int j = 1; j < inputTable.GetLength(1); j++) {
                    L.SubItems.Add(getBoolStr(inputTable[i, j]));
                }
                L.SubItems.Add(getBoolStr(bemenet[i]));
            }
        }

        private string getBoolStr(bool b)
        {
            return b ? "1" : "0";
        }

        private bool validateInputs()
        {
            if (inLogFüg.Text == "") {
                MessageBox.Show("Adat nélkül nem tudom generálni az igazságtáblát.");
                return false;
            }

            if (errors) {
                MessageBox.Show("Hibásan adta meg a függvényt.");
                return false;
            }

            return true;
        }

        private bool[,] GenInputTable(int col)
        {
            bool[,] table;
            int row = (int)Math.Pow(2, col);

            table = new bool[row, col];

            int divider = row;

            // iterálás oszloponként:
            for (int c = 0; c < col; c++) {
                divider /= 2;
                bool cell = false;
                // iterálás, minden sor az oszlop indexével:
                for (int r = 0; r < row; r++) {
                    table[r, c] = cell;
                    if ((divider == 1) || ((r + 1) % divider == 0)) {
                        cell = !cell;
                    }
                }
            }

            return table;
        }

        private void hogyanMenuStrip_Click(object sender, EventArgs e)
        {
            string text =
                "+ => OR logikai vagy\n" +
                "* => AND logikai és\n" +
                "^ => XOR logikai kizáró\n" +
                "' => NOT logikai nem\n\n" +
                "Példa: A(B^C')'+D\n\n" +
                "^ -> ALT + 94";
            MessageBox.Show(text);
        }


    }
}
