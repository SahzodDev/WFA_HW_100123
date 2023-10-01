namespace WFA_HW_100123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sifreUzunlugu = 0, sifreSayisi = 0;
        List<string> sifreler = new List<string>();
        List<char> sifre = new List<char>();
        Random rnd = new Random();

        private void btnUret_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSifreSayisi.Text) > 0 && int.Parse(txtSifreUzunlugu.Text) > 0)
                {
                    sifreSayisi = int.Parse(txtSifreSayisi.Text);
                    sifreUzunlugu = int.Parse(txtSifreUzunlugu.Text);

                    if (chkKucukHarf.Checked || chkBuyukHarf.Checked || chkOzelKarakter.Checked || chkRakam.Checked)
                    {
                        if (chkKucukHarf.Checked)
                        {
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    char c = (char)(rnd.Next(97, 123));
                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkBuyukHarf.Checked)
                        {
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    char c = (char)(rnd.Next(65, 91));
                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkRakam.Checked)
                        {
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    char c = (char)(rnd.Next(48, 58));
                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkOzelKarakter.Checked)
                        {
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    char c = (char)(rnd.Next(33, 48));
                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        if (chkBuyukHarf.Checked && chkKucukHarf.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 3);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(65, 91));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(97, 123));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkBuyukHarf.Checked && chkRakam.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 3);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(65, 91));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(48, 58));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkBuyukHarf.Checked && chkOzelKarakter.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 3);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(65, 91));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(33, 48));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkKucukHarf.Checked && chkRakam.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 3);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(97, 123));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(48, 58));
                                    }
                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkKucukHarf.Checked && chkOzelKarakter.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 3);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(97, 123));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(33, 48));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkRakam.Checked && chkOzelKarakter.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 3);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(48, 57));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(33, 48));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        if (chkBuyukHarf.Checked && chkKucukHarf.Checked && chkRakam.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 4);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(65, 91));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(97, 123));
                                    }
                                    else if (a == 3)
                                    {
                                        c = (char)(rnd.Next(48, 58));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkBuyukHarf.Checked && chkKucukHarf.Checked && chkOzelKarakter.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 4);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(65, 91));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(97, 123));
                                    }
                                    else if (a == 3)
                                    {
                                        c = (char)(rnd.Next(33, 48));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkBuyukHarf.Checked && chkRakam.Checked && chkOzelKarakter.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 4);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(65, 91));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(48, 58));
                                    }
                                    else if (a == 3)
                                    {
                                        c = (char)(rnd.Next(33, 48));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        else if (chkKucukHarf.Checked && chkRakam.Checked && chkOzelKarakter.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 4);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(97, 123));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(48, 58));
                                    }
                                    else if (a == 3)
                                    {
                                        c = (char)(rnd.Next(33, 48));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                        if (chkBuyukHarf.Checked && chkKucukHarf.Checked && chkRakam.Checked && chkOzelKarakter.Checked)
                        {
                            char c = default;
                            lstSifreler.Items.Clear();
                            for (int i = 0; i < sifreSayisi; i++)
                            {
                                for (int k = 0; k < sifreUzunlugu; k++)
                                {
                                    int a = rnd.Next(1, 5);
                                    if (a == 1)
                                    {
                                        c = (char)(rnd.Next(97, 123));
                                    }
                                    else if (a == 2)
                                    {
                                        c = (char)(rnd.Next(48, 58));
                                    }
                                    else if (a == 3)
                                    {
                                        c = (char)(rnd.Next(33, 48));
                                    }
                                    else if (a == 4)
                                    {
                                        c = (char)(rnd.Next(65, 91));
                                    }

                                    sifre.Add(c);
                                }
                                string parola = new string(sifre.ToArray());
                                sifreler.Add(parola);
                                sifre.Clear();
                            }
                            foreach (string parola in sifreler)
                            {
                                lstSifreler.Items.Add(parola);
                            }
                            sifreler.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen þifrenin oluþmasý içinbir þart belirleyin.");
                        lstSifreler.Items.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen þifre uzunluðu ve þifre sayýsý bölümüne yalnýzca pozitif tam sayý giriniz.");
                    lstSifreler.Items.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Lütfen þifre uzunluðu ve þifre sayýsý bölümüne yalnýzca pozitif tam sayý giriniz.");
                lstSifreler.Items.Clear();
            }

            
        }
    }
}