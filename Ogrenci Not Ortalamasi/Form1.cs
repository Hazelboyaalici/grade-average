namespace Ogrenci_Not_Ortalamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            string AdSoyad;
            int vize, final;
            double ortalama;
            AdSoyad = textBox1.Text;
            vize = Convert.ToInt16(MskVize.Text);
            final = Convert.ToInt16(MskFinal.Text);

            ortalama = Convert.ToDouble (vize *0.3 + final * 0.7) ;


            listBox1.Items.Add("��rencinin Ad� Soyad�: "+ AdSoyad);
            listBox1.Items.Add("��rencinin Vize Notu:" + vize);
            listBox1.Items.Add("��rencinin Fina� Notu: "+ final);

            listBox1.Items.Add("��rencinin Ad� Soyad�: " +ortalama.ToString("0.00"));
                

            

        }
    }
}