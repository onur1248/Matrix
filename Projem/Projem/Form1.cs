using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    public partial class Form1 : Form
    {
        public int str, stn, str2, stn2 , q=0, w=0,a=0,s=0;

        double[,] adj = new double[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        //ComboBox seçim
        private void Satır_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = Convert.ToInt32(Satır.Text);
            matrisolustur();
        }
        private void Sutun_SelectedIndexChanged(object sender, EventArgs e)
        {
            stn = Convert.ToInt32(Sutun.Text);
            matrisolustur();
        }
        private void Satır2_SelectedIndexChanged(object sender, EventArgs e)
        {
            str2 = Convert.ToInt32(Satır2.Text);
            matrisolustur2();
        }
        private void Sutun2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stn2 = Convert.ToInt32(Sutun2.Text);
            matrisolustur2();
        }

        //Buton Kontrolleri
        private void button1_Click(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                if (str == str2 && stn == stn2)
                {
                    toplama();
                }
                else
                    MessageBox.Show("İşleminizin yapılabilmesi için matrisler aynı boyutta olmalıdır.",
                        "Bilgilendirme Penceresi");
            }
            else if (radio2.Checked == true)
            {
                if (str == str2 && stn == stn2)
                {
                    cıkarma();
                }
                else
                    MessageBox.Show("İşleminizin yapılabilmesi için matrisler aynı boyutta olmalıdır.",
                        "Bilgilendirme Penceresi");
            }
            else if (radio3.Checked == true)
            {
                if (stn == str2)
                {
                    carpma();
                }
                else
                    MessageBox.Show("İşleminizin yapılabilmesi için matrisin boyutunu doğru ayarlayınız.",
                        "Bilgilendirme Penceresi");
            }
            else if (radio4.Checked == true)
            {
                sayiCarp();
            }
            else if (radio5.Checked == true)
            {
                adevir();
            }
            else if (radio6.Checked == true)
            {
                bdevir();
            }
            else if (radio7.Checked == true)
            {
                if (str == stn)
                {
                    aters();
                }
                else
                    MessageBox.Show("İşleminizin yapılabilmesi için matris kare matris olmalıdır.",
                        "Bilgilendirme Penceresi");
            }
            else if (radio8.Checked == true)
            {
                if (str2 == stn2)
                {
                    bters();
                }
                else
                    MessageBox.Show("İşleminizin yapılabilmesi için matris kare matris olmalıdır.",
                        "Bilgilendirme Penceresi");
            }
            else if (radio9.Checked == true)
            {
                if (str == stn)
                {
                    adeterminant();
                }
                else
                    MessageBox.Show("İşleminizin yapılabilmesi için matris kare matris olmalıdır.",
                        "Bilgilendirme Penceresi");
            }
            else if (radio10.Checked == true)
            {
                if (str2 == stn2)
                {
                    bdeterminant();
                }
                else
                    MessageBox.Show("İşleminizin yapılabilmesi için matris kare matris olmalıdır.",
                        "Bilgilendirme Penceresi");
            }
            else
                MessageBox.Show("İşleminiz için seçim yapınız");
        }
       
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }


        //Matrislerin ekrana yazdırılması
        private void matrisolustur()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    foreach (Control item in this.Controls.OfType<Control>())
                    {
                        string name = "sayi" + i + j;
                        if (item.Name == name)
                        {
                            this.Controls.Remove(item);
                        }
                    }
                }
            }


            int x = 50, y = 65;
            for (int i = 0; i < str; i++)
            {
                x = 50; y += 20;
                for (int j = 0; j < stn; j++)
                {

                    TextBox t = new TextBox();
                    t.Name = "sayi" + i + j;

                    t.Size = new Size(20, 20);

                    t.Location = new Point(x, y);
                    //yeni düğmenin yerleştirileceği yer.
                    x += 20;

                    this.Controls.Add(t);
                }
            }
        }
        private void matrisolustur2()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    foreach (Control item in this.Controls.OfType<Control>())
                    {
                        string name = "say" + i + j;
                        if (item.Name == name)
                        {
                            this.Controls.Remove(item);
                        }
                    }
                }
            }

            int a = 225, b = 65;
            for (int i = 0; i < str2; i++)
            {
                a = 225; b += 20;
                for (int j = 0; j < stn2; j++)
                {

                    TextBox t2 = new TextBox();
                    t2.Name = "say" + i + j;

                    t2.Size = new Size(20, 20);

                    t2.Location = new Point(a, b);
                    //yeni düğmenin yerleştirileceği yer.
                    a += 20;

                    this.Controls.Add(t2);
                }
            }
        }
        private void matrissonucyazdır(double[,] mtrs)
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    foreach (Control item in this.Controls.OfType<Control>())
                    {
                        string name = "snc" + i + j;
                        if (item.Name == name || item.Name == "sncdet" || item.Name == "sncdet2")
                        {
                            this.Controls.Remove(item);
                        }
                    }
                }
            }
            int a = 135, b = 220;
            for (int i = 0; i < str; i++)
            {
                a = 135; b += 20;
                for (int j = 0; j < stn2; j++)
                {
                    TextBox sonuc = new TextBox();
                    sonuc.Name = "snc" + i + j;
                    sonuc.ReadOnly = true;
                    sonuc.Size = new Size(20, 20);

                    sonuc.Location = new Point(a, b);
                    sonuc.Text = Convert.ToString(mtrs[i, j]);
                    a += 20;

                    this.Controls.Add(sonuc);
                }
            }
        }
        private void matrissonucyazdır1(double[,] mtrs)//Transpoze A matrisi
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    foreach (Control item in this.Controls.OfType<Control>())
                    {
                        string name = "snc" + i + j;
                        if (item.Name == name || item.Name == "sncdet" || item.Name == "sncdet2")
                        {
                            this.Controls.Remove(item);
                        }
                    }
                }
            }
            int a = 135, b = 220;
            for (int i = 0; i < stn; i++)
            {
                a = 135; b += 20;
                for (int j = 0; j < str; j++)
                {
                    TextBox sonuc = new TextBox();
                    sonuc.Name = "snc" + i + j;
                    sonuc.ReadOnly = true;
                    sonuc.Size = new Size(20, 20);

                    sonuc.Location = new Point(a, b);
                    sonuc.Text = Convert.ToString(mtrs[i, j]);
                    a += 20;

                    this.Controls.Add(sonuc);
                }
            }
        }
        private void matrissonucyazdır2(double[,] mtrs)//Transpoze B matrisi
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    foreach (Control item in this.Controls.OfType<Control>())
                    {
                        string name = "snc" + i + j;
                        if (item.Name == name || item.Name == "sncdet" || item.Name == "sncdet2")
                        {
                            this.Controls.Remove(item);
                        }
                    }
                }
            }
            int a = 135, b = 220;
            for (int i = 0; i < stn2; i++)
            {
                a = 135; b += 20;
                for (int j = 0; j < str2; j++)
                {
                    TextBox sonuc = new TextBox();
                    sonuc.Name = "snc" + i + j;
                    sonuc.ReadOnly = true;
                    sonuc.Size = new Size(20, 20);

                    sonuc.Location = new Point(a, b);
                    sonuc.Text = Convert.ToString(mtrs[i, j]);
                    a += 20;

                    this.Controls.Add(sonuc);
                }
            }
        }
        private void matrissonucyazdır3(double[,] mtrs)//SayıÇarpımı ,Ters
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    foreach (Control item in this.Controls.OfType<Control>())
                    {
                        string name = "snc" + i + j;
                        if (item.Name == name || item.Name == "sncdet" || item.Name == "sncdet2")
                        {
                            this.Controls.Remove(item);
                        }
                    }
                }
            }
            int a = 135, b = 220;
            for (int i = 0; i < str; i++)
            {
                a = 135; b += 20;
                for (int j = 0; j < stn; j++)
                {
                    TextBox sonuc = new TextBox();
                    sonuc.Name = "snc" + i + j;
                    sonuc.ReadOnly = true;
                    sonuc.Size = new Size(20, 20);

                    sonuc.Location = new Point(a, b);
                    sonuc.Text = Convert.ToString(mtrs[i, j]);
                    a += 20;

                    this.Controls.Add(sonuc);
                }
            }
        }

        //MATEMATİKSEL İŞLEMLER
        private void toplama()
        {
            try
            {
                double[,] matris1 = new double[str, stn];
                double[,] matris2 = new double[str2, stn2];
                double[,] matrissonuc = new double[str, stn];
                

                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stn; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "sayi" + i + j;
                            string name2 = "say" + i + j;

                            if (item.Name == name)
                            {
                                matris1[i, j] = Convert.ToDouble(item.Text);
                            }
                            if (item.Name == name2)
                            {
                                matris2[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }

                for (int k = 0; k < str; k++)
                {
                    for (int l = 0; l < stn; l++)
                    {
                        matrissonuc[k, l] = matris1[k, l] + matris2[k, l];
                    }
                }
                matrissonucyazdır(matrissonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris elemanları boş olmamalıdır ve rakam girilmelidir", "Bilgilendirme Penceresi");
            }

        }
        private void cıkarma()
        {
            try
            {
                double[,] matris1 = new double[str, stn];
                double[,] matris2 = new double[str2, stn2];
                double[,] matrissonuc = new double[str, stn];

                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stn; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "sayi" + i + j;
                            string name2 = "say" + i + j;

                            if (item.Name == name)
                            {
                                matris1[i, j] = Convert.ToDouble(item.Text);
                            }
                            if (item.Name == name2)
                            {
                                matris2[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }

                for (int k = 0; k < str; k++)
                {
                    for (int l = 0; l < stn; l++)
                    {
                        matrissonuc[k, l] = matris1[k, l] - matris2[k, l];
                    }
                }
                matrissonucyazdır(matrissonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris elemanları boş olmamalıdır", "Bilgilendirme Penceresi");
            }
        }
        private void carpma()
        {
            try
            {
                double[,] matris1 = new double[5, 5];
                double[,] matris2 = new double[5, 5];
                double[,] matrissonuc = new double[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "sayi" + i + j;

                            if (item.Name == name)
                            {
                                matris1[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name2 = "say" + i + j;
                            if (item.Name == name2)
                            {
                                matris2[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        double toplam = 0;
                        for (int k = 0; k < 5; k++)
                        {
                            toplam = toplam + matris1[i, k] * matris2[k, j];
                        } 
                        matrissonuc[i, j] = toplam;
                    }
                }
                matrissonucyazdır(matrissonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris elemanları boş olmamalıdır", "Bilgilendirme Penceresi");
            }
        }
        private void sayiCarp()
        {
            try
            {
                double[,] matris1 = new double[5, 5];
                double[,] matrissonuc = new double[5, 5];
                double sayiCarp = Convert.ToDouble(Carp.Text);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "sayi" + i + j;

                            if (item.Name == name)
                            {
                                matris1[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        
                         matrissonuc[i, j] = matris1[i, j] *sayiCarp;
                    }
                }
                matrissonucyazdır3(matrissonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris elemanları ve çarpılacak sayı boş olmamalıdır", "Bilgilendirme Penceresi");
            }
        }
        private void adevir()
        {
            try
            {
                double[,] matris1 = new double[5, 5];
                double[,] matrissonuc = new double[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "sayi" + i + j;

                            if (item.Name == name)
                            {
                                matris1[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        matrissonuc[i, j] = matris1[j, i];
                    }
                }
                matrissonucyazdır1(matrissonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris elemanları boş olmamalıdır", "Bilgilendirme Penceresi");
            }
        }
        private void bdevir()
        {
            try
            {
                double[,] matris2 = new double[5, 5];
                double[,] matrissonuc = new double[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "say" + i + j;

                            if (item.Name == name)
                            {
                                matris2[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        matrissonuc[i, j] = matris2[j, i];
                    }
                }
                matrissonucyazdır2(matrissonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris elemanları boş olmamalıdır", "Bilgilendirme Penceresi");
            }
        }
        private void adeterminant()
        {
            try
            {
                double[,] matris1 = new double[str, stn];
                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stn; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "sayi" + i + j;

                            if (item.Name == name)
                            {
                                matris1[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
                int kp1;
                double p;
                double det = 1;
                for (int k = 0; k < str-1; k++)
                {
                    kp1 = k + 1;
                    for (int i = kp1; i < str; i++)
                    {
                        p = matris1[i, k] / matris1[k, k];
                        for (int j = kp1; j < str; j++)
                            matris1[i, j] = matris1[i, j] - p * matris1[k, j];
                    }
                }
                for (int i = 0; i < str; i++)
                    det = det * matris1[i, i];

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "snc" + i + j;
                            if (item.Name == name || item.Name == "sncdet" || item.Name == "sncdet2")
                            {
                                this.Controls.Remove(item);
                            }
                        }
                    }
                }
                
                
                
                int a = 120, b = 268;
                TextBox sonuc = new TextBox();
                sonuc.Name = "sncdet";
                sonuc.ReadOnly = true;
                sonuc.Size = new Size(40, 20);
                sonuc.Location = new Point(a, b);
                sonuc.Text = Convert.ToString(det);
                this.Controls.Add(sonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris alanına rakam girilmelidir.");
            }
        }
        private void bdeterminant()
        {
            try
            {
                double[,] matris2 = new double[5, 5];
                for (int i = 0; i < str2; i++)
                {
                    for (int j = 0; j < stn2; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "say" + i + j;

                            if (item.Name == name)
                            {
                                matris2[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
                int kp1;
                double p;
                double det = 1;
                for (int k = 0; k < str2 - 1; k++)
                {
                    kp1 = k + 1;
                    for (int i = kp1; i < str2; i++)
                    {
                        p = matris2[i, k] / matris2[k, k];
                        for (int j = kp1; j < str2; j++)
                            matris2[i, j] = matris2[i, j] - p * matris2[k, j];
                    }
                }
                for (int i = 0; i < str2; i++)
                    det = det * matris2[i, i];

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "snc" + i + j;
                            if (item.Name == name || item.Name == "sncdet" || item.Name == "sncdet2")
                            {
                                this.Controls.Remove(item);
                            }
                        }
                    }
                }
                int a = 120, b = 268;
                TextBox sonuc = new TextBox();
                sonuc.Name = "sncdet2";
                sonuc.ReadOnly = true;
                sonuc.Size = new Size(40, 20);
                sonuc.Location = new Point(a, b);
                sonuc.Text = Convert.ToString(det);
                this.Controls.Add(sonuc);
            }
            catch (Exception)
            {
                MessageBox.Show("Matris alanına rakam girilmelidir.");
            }
        }
        private void aters()
        {
                double[,] matris1 = new double[5, 5];
                double[,] sonucc=new double[5,5];

                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stn; j++)
                    {
                        foreach (Control item in this.Controls.OfType<Control>())
                        {
                            string name = "sayi" + i + j;

                            if (item.Name == name)
                            {
                                matris1[i, j] = Convert.ToDouble(item.Text);
                            }
                        }
                    }
                }
            /*double[,] Adj = new double[str, str];
            double[,] deger = new double[str, stn];

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stn; j++)
                {
                    for (int k = 0, g=0; k < str && g <str; k++,g++)
                    {
                        for (int l = 0,h=0; l < str && h <str ; l++,h++)
                        {
                            if (k!=i && l!=j)
                            {
                                deger[g, h] = matris1[k, l];
                            }
                        }
                    }
                Adj[i, j] = detr(deger);
                }
            }*/

            detr(matris1);
            matrissonucyazdır1(adj);
            //int a = 120, b = 268;
            //TextBox sonuc = new TextBox();
            //sonuc.Name = "sncdet";
            //sonuc.ReadOnly = true;
            //sonuc.Size = new Size(40, 20);
            //sonuc.Location = new Point(a, b);
            //sonuc.Text = Convert.ToString(sonucc);
            //this.Controls.Add(sonuc);

        }

        

        private void bters()
        {

            double[,] olusan = new double[str , str ];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < str; j++)
                {
                    olusan[i, j] = i * j + 2;
                }
            }
           
            MessageBox.Show(Convert.ToString( detters(olusan)));
        }
        private double detters(double[,] min)
        {
            for (int i = 0; i < str-2; i++)
            {
                for (int j = 0; j < str-2; j++)
                {

                    MessageBox.Show(Convert.ToString(min[i, j]));
                }
            }
            int kp1;
            double p;
            double det= 1;
            for (int k = 0; k < str - 2; k++)
            {
                kp1 = k + 1;
                for (int i = kp1; i < str-1; i++)
                {
                    p = min[i, k] / min[k, k];
                    for (int j = kp1; j < str-1; j++)
                        min[i, j] = min[i, j] - p * min[k, j];
                }
            }
            for (int i = 0; i < str-1; i++)
            { det = det * min[i, i]; }

           
            return det;
        }
        private void adjolustur(double gelen)
        {

            double[,] olusan = new double[str-1, str-1];
            double[,] son = new double[str - 1, str - 1];

            son[a, s] = adj[a, s];
            olusan[q,w] = gelen;

            //MessageBox.Show(Convert.ToString(olusan[q,w]));
            w++;
            if (w==str-2)
            {
                w = 0;
                q++;
            }
            if (q == str - 2)
            {
                q = 0;
            }
            if (w == 0     && q==0)
            {
                    adj[a,s]=detters(olusan);
               // MessageBox.Show(Convert.ToString(detters(olusan)));
                
                s++;
                if (s == str-1)
                {
                    s = 0;
                    a++;
                }
                if (a == str - 1)
                {
                    a = 1;
                }
            }


        }
        private void detr(double[,] mtrs)
        {
            double[,] min = new double[str, str];
            double[,] deger = new double[str, stn];
            double[,] adj=new double[str,str];
            double[,] deneme = new double[str, str];
            double[] dizi = new double[20];
            

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stn; j++)
                {
                    for (int k = 0; k < str; k++ )
                    {
                        for (int l = 0; l < str ; l++ )
                        {
                            if (k != i && l != j)
                            {
                                adjolustur(mtrs[k, l]);

                               // MessageBox.Show(Convert.ToString(mtrs[k,l]));
                            }
                            
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Satır.Items.Add("1");
            Satır.Items.Add("2");
            Satır.Items.Add("3");
            Satır.Items.Add("4");
            Satır.Items.Add("5");
            Satır.Text = "3";
            Satır2.Items.Add("1");
            Satır2.Items.Add("2");
            Satır2.Items.Add("3");
            Satır2.Items.Add("4");
            Satır2.Items.Add("5");
            Satır2.Text = "3";
            Sutun.Items.Add("1");
            Sutun.Items.Add("2");
            Sutun.Items.Add("3");
            Sutun.Items.Add("4");
            Sutun.Items.Add("5");
            Sutun.Text = "3";
            Sutun2.Items.Add("1");
            Sutun2.Items.Add("2");
            Sutun2.Items.Add("3");
            Sutun2.Items.Add("4");
            Sutun2.Items.Add("5");
            Sutun2.Text = "3";
        }
    }
}

