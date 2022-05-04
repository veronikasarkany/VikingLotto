using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VikingLottoAdatBazis;

namespace VikingSzimulacio
{
    public partial class Form1 : Form
    {
        private List<int> tipp = new List<int>();
        private VikingContext dn = new VikingContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tipp.Add(Convert.ToInt32(box.Text));
                if (tipp.Count() == 6)
                {
                    btnSorsol.Enabled = true;
                    foreach (var item in this.Controls)
                    {
                        if (item.ToString().Contains("CheckBox"))
                        {
                            if (!((CheckBox)item).Checked)
                                ((CheckBox)item).Enabled = false;
                        }
                    }
                }
            }
            else
            {
                tipp.Remove(Convert.ToInt32(box.Text));
                if (tipp.Count() == 5)
                {
                    btnSorsol.Enabled = false;
                    foreach (var item in this.Controls)
                    {
                        if (item.ToString().Contains("CheckBox"))
                        {
                            ((CheckBox)item).Enabled = true;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSorsol.Enabled = false;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 8; j++)
                {
                    CheckBox box = new CheckBox();
                    box.AutoSize = true;
                    box.Location = new Point(j * 50 + 50, i * 50 + 50);
                    box.Text = (i * 8 + j + 1).ToString();
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    this.Controls.Add(box);
                }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            Random vel = new Random();
            HashSet<int> halmaz = new HashSet<int>();

            do
            {
                halmaz.Add(vel.Next(1, 49));
            } while (halmaz.Count()!=6);

            dn.LottoSzamok.Add(new LottoSzam(string.Join(";",halmaz)));
            dn.SaveChanges();

            MessageBox.Show(halmaz.Intersect(tipp).Count().ToString()+" találatod lett!");


        }
    }
}
