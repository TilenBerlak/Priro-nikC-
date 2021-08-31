using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrijski_liki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vklopiLastnostiLabel(bool a = false, bool b = false, bool c = false, bool d = false, bool v = false, bool r = false)
        {
            label_stranicaA.Enabled = a;
            label_stranicaB.Enabled = b;
            label_stranicaC.Enabled = c;
            //label_stranicaD.Enabled = d;
            comboBox_visina.Enabled = v;
            label_polmer.Enabled = r;
        }

        private void vklopiLastnostiNumeric(bool A = false, bool B = false, bool C = false, bool D = false, bool V = false, bool R = false)
        {
            numericUpDown_stranicaA.Enabled = A;
            numericUpDown_stranicaB.Enabled = B;
            numericUpDown_stranicaC.Enabled = C;
            //numericUpDown_stranicaD.Enabled = D;
            numericUpDown_visina.Enabled = V;
            numericUpDown_polmer.Enabled = R;
        }

        private void radioButton_pravokotnik_CheckedChanged(object sender, EventArgs e)
        {
            vklopiLastnostiLabel(true,true);
            vklopiLastnostiNumeric(true, true);
            pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.pravokotnik;
        }

        private void radioButton_trikotnik_CheckedChanged(object sender, EventArgs e)
        {
            vklopiLastnostiLabel(true, true, true, false, true);
            vklopiLastnostiNumeric(true, true, true, false, true);
            pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.trikotnik_navadni;
        }

        private void radioButton_kvadrat_CheckedChanged(object sender, EventArgs e)
        {
            vklopiLastnostiLabel(true);
            vklopiLastnostiNumeric(true);
            pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.kvadrat;
        }

        private void radioButton_enakokraki_CheckedChanged(object sender, EventArgs e)
        {
            vklopiLastnostiLabel(true,false,true,false,true);
            vklopiLastnostiNumeric(true,false,true,false,true);
            comboBox_visina.SelectedItem = "Višina (vc):";
            pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.trikotnik_enakokraki;
        }

        private void radioButton_enakostranicni_CheckedChanged(object sender, EventArgs e)
        {
            vklopiLastnostiLabel(true,false,false,false,true);
            vklopiLastnostiNumeric(true,false,false,false,true);
            comboBox_visina.SelectedItem = "Višina (va):";
            pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.trikotnik_enakostranicni;
        }

        private void radioButton_krog_CheckedChanged(object sender, EventArgs e)
        {
            vklopiLastnostiLabel(false,false,false,false,false,true);
            vklopiLastnostiNumeric(false,false,false,false,false,true);
            pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.krog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown_stranicaA.Value = 0;
            numericUpDown_stranicaB.Value = 0;
            numericUpDown_stranicaC.Value = 0;
            //numericUpDown_stranicaD.Value = 0;
            numericUpDown_visina.Value = 0;
            numericUpDown_polmer.Value = 0;
            numericUpDown_obseg.Value = 0;
            numericUpDown_ploscina.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(radioButton_kvadrat.Checked) // Računanje kvadrata
            {
                decimal a = numericUpDown_stranicaA.Value;

                decimal obseg = 4 * a;
                decimal ploscina = a * a;

                numericUpDown_obseg.Value = obseg;
                numericUpDown_ploscina.Value = ploscina;
            }
            else if(radioButton_pravokotnik.Checked) // Računanje pravokotnika
            {
                decimal a = numericUpDown_stranicaA.Value;
                decimal b = numericUpDown_stranicaB.Value;

                if(a == b)
                {
                    pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.kvadrat;
                }
                else
                {
                    pictureBox_slika.Image = Geometrijski_liki.Properties.Resources.pravokotnik;
                }

                decimal obseg = (2 * a) + (2 * b);
                decimal ploscina = a * b;
                numericUpDown_obseg.Value = obseg;
                numericUpDown_ploscina.Value = ploscina;
            }
            else if(radioButton_trikotnik.Checked) // Računanje navadnega trikotnika
            {
                decimal a = numericUpDown_stranicaA.Value;
                decimal b = numericUpDown_stranicaB.Value;
                decimal c = numericUpDown_stranicaC.Value;
                decimal v = numericUpDown_visina.Value;

                decimal obseg = a + b + c;
                decimal ploscina = 0;

                switch(comboBox_visina.Text) // Preveri katera visina je izbrana
                {
                    case "Višina (va):":
                        ploscina = (a * v)/2;
                        break;
                    case "Višina (vb):":
                        ploscina = (b * v)/2;
                        break;
                    case "Višina (vc):":
                        ploscina = (c * v)/2;
                        break;
                }
                
                numericUpDown_obseg.Value = obseg;
                numericUpDown_ploscina.Value = ploscina;
            }
            else if(radioButton_enakokraki.Checked) // Računanje enakokrakega trikotnika
            {
                decimal a = numericUpDown_stranicaA.Value;
                decimal c = numericUpDown_stranicaC.Value;
                decimal v = numericUpDown_visina.Value;

                decimal obseg = (2 * a) + c;
                decimal ploscina = 0;

                if (comboBox_visina.Text == "Višina (vc):")
                {
                    if (a > 0 && c > 0)
                    {
                        decimal c2 = c / 2;
                        ploscina = 2 * (a * c2 / 2);
                    }
                    else if (a > 0 && v > 0 && c == 0 && v < a)
                    {
                        decimal c2 = (decimal)Math.Sqrt((double)(a * a) - (double)(v * v));
                        ploscina = 2 * (c2 * a / 2);
                    }
                    else if (a > 0 && v > 0 && c == 0 && v > a)
                    {
                        MessageBox.Show("Enakokraki trikotnik: višina ne more biti večja od kraka.");
                    }
                    else if(c > 0 && v > 0 && a == 0)
                    {
                        decimal a2 = (c / 2) * (c / 2) + v * v;
                        ploscina = 2 * (a2 * (c/2) / 2);
                    }

                    numericUpDown_ploscina.Value = ploscina;
                    numericUpDown_obseg.Value = obseg;

                }
             
            }
            else if (radioButton_krog.Checked)
            {
                decimal r = numericUpDown_polmer.Value;

                decimal obseg = 2 * (decimal)Math.PI * r;
                decimal ploscina = (decimal)Math.PI * (r * r);

                numericUpDown_obseg.Value = obseg;
                numericUpDown_ploscina.Value = ploscina;

            }
            else if(radioButton_enakostranicni.Checked)
            {
                decimal a = numericUpDown_stranicaA.Value;
                decimal v = numericUpDown_visina.Value;

                decimal obseg = 3 * a;
                decimal ploscina = (a * (decimal)Math.Sqrt(3)) / 2;

                numericUpDown_obseg.Value = obseg;
                numericUpDown_ploscina.Value = ploscina;
            }

        }
    }
}
