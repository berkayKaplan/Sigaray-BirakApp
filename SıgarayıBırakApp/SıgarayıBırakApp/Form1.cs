using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SıgarayıBırakApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan fark;
            fark = DateTime.Today - DateTime.Parse(dateTimePicker1.Text);
            label5.Text = fark.TotalDays.ToString();

            double islem;
            double a = Convert.ToInt32(label5.Text);
            double b = Convert.ToInt32(textBox1.Text);
            islem = a * b;
            label7.Text = islem.ToString();
            double Islem;
            double c = Convert.ToInt32(textBox2.Text);
            Islem= (islem / 20) * c;
            label9.Text = Islem.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> cümleler = new List<string>();
            cümleler.Add("UNUTMAYIN siz sigara içtiğinizde hayatınızdaki dakikalar götürüyorsunuz peki siz her içtiğinizde sevdiğiniz birinin hayatından dakikalar alsaydınız halen içmeye devam edermiydiniz  ");
            cümleler.Add("Bir gün bile bile kendi yaşamınızdan çaldığınız o dakikalar için muhtaç kalmayın!!!");
            cümleler.Add("Sigara iç dedeni gör, sigara içme torununu gör.");
            cümleler.Add("İçtiğimiz sigara değiI asIında; pişmanIığımız, yaInızIığımız, mutsuzIuğumuzdur. ÜfIediğimiz duman ise umudumuz.Umutlarını bi dumana değilde bi İNSANA bağla");
            cümleler.Add("Günümüzde tütün kullanımı,dünyada tek başına en önemli ÖLÜM nedeni.Tütünden kaynaklı hastalıklar sebebiyle her yıl 6 MİLYON KİŞİ SEVDİKLERİNDEN KOPUYOR .Neden sıradaki sen olasın!!");
            cümleler.Add("SigarayIa akIa geIen izmaritIe yere düşer.");
            cümleler.Add("annem hep söyler.düşmanın varsa sigara uzat...");
            cümleler.Add("bok iç kardesim.");
            cümleler.Add("sevdiklerin için söz ver sigaraya son ver ");
            cümleler.Add("sonuçları fark etmeye başladığınızda sigarayı bıraktan başka bir seçeneğiniz kalmıyor-Mat Damon");
            foreach (string cümle in cümleler)
            {
                MessageBox.Show(cümle);
            }

        }
    }
}
