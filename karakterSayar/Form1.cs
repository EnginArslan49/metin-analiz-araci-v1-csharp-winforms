namespace karakterSayar
{
    // Author: Engin ARSLAN ~ Arslan Yazýlým (arslanengin.com.tr)
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Form bileþenlerini baþlat (otomatik oluþturulan kod)

            txtReferansMetin.Focus(); // Metin kutusuna odaklan
            btnTemizle.Enabled = false; // Temizle butonunu baþlangýçta devre dýþý býrak
            gorunurlukAyarlama(false); // Baþlangýçta belirli elemanlarý gizle
        }

        public bool _duzenlemeModundaMi = false; // Düzenleme modunu takip eden deðiþken. Bu deðiþken ile temizleme butonunun görünürlük durumunu kontrol edeceðiz.

        private void btnKarakterSay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReferansMetin.Text))
            {
                MessageBox.Show("Lütfen analizi yapýlacak metni giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReferansMetin.Text = ""; // Boþluk girilmesine karþý metin kutusunu temizle
                txtReferansMetin.Focus();
                return; // Ýþlemi sonlandýr
            }

            // Metni boþluklara göre ayýr ve sayýlarý tutacak bir dizi oluþtur. 
            string[] sayilarString = txtReferansMetin.Text.Split(' ');
            int[] sayilar = new int[sayilarString.Length];

            // Girilen metindeki içerik bir kelime ise 
            if (sayilar.Length > 1)
            {
                _duzenlemeModundaMi = true; // Düzenleme modunu etkinleþtir

                btnKarakterSay.Enabled = false; // Karakter Say butonunu geçici olarak devre dýþý býrak
                btnTemizle.Enabled = false; // Temizle butonunu geçici olarak devre dýþý býrak

                lblBilgilendirme.Text = "";
                lblBilgilendirme.Visible = false; // Bilgilendirme etiketini gizle

                string metin = txtReferansMetin.Text; // Metin kutusundaki metni al
                int karakterSayisi = metin.Length; // Metindeki karakter sayýsýný hesapla
                string[] kelimeler = metin.Split(' '); // Metni boþluklara göre kelimelere ayýr

                int kelimeSayisi = kelimeler.Length; // Kelime sayýsýný hesapla
                string enKisaKelime = kelimeler.OrderBy(k => k.Length).FirstOrDefault(); // En kýsa kelimeyi bul
                string enUzunKelime = kelimeler.OrderByDescending(k => k.Length).FirstOrDefault(); // En uzun kelimeyi bul
                int cumleSayisi = metin.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length; // Cümle sayýsýný hesapla

                gorunurlukAyarlama(true); // Sonuçlarý göstermek için belirli elemanlarý görünür yap

                txtGirilenMetninUzunlugu.Text = karakterSayisi.ToString() + " (boþluklar dahil)"; // Karakter sayýsýný metin kutusuna yaz
                txtGirilenMetninCumleUzunlugu.Text = cumleSayisi.ToString(); // Cümle sayýsýný metin kutusuna yaz
                txtEnKisaKelime.Text = enKisaKelime; // En kýsa kelimeyi metin kutusuna yaz
                txtEnUzunKelime.Text = enUzunKelime; // En uzun kelimeyi metin kutusuna yaz
            }
            else
            {
                lblBilgilendirme.Visible = true;
                lblBilgilendirme.Text = "Girmiþ olduðunuz metin 1 kelimeden oluþmaktadýr." + Environment.NewLine + "Ölçüm yapýlabilmesi için en az 2 kelime giriniz.";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            gorunurlukAyarlama(false);
            txtReferansMetin.Clear();
            txtReferansMetin.Focus();
        }

        private void btnYeniIcerikSay_Click(object sender, EventArgs e)
        {
            YeniIcerikSay();
        }

        private void menuYeniIcerikSay_Click(object sender, EventArgs e)
        {
            YeniIcerikSay();
        }

        public void YeniIcerikSay()
        {
            _duzenlemeModundaMi = false; // Düzenleme modunu devre dýþý býrak

            btnKarakterSay.Enabled = true; // Karakter Say butonunu etkinleþtir
            txtReferansMetin.Clear();
            txtReferansMetin.Focus();
            gorunurlukAyarlama(false);
        }

        public void gorunurlukAyarlama(bool durum)
        {
            // Girilen metnin uzunluðunu gösteren etiket ve metin kutusu
            lblGirilenMetninUzunlugu.Visible = durum;
            txtGirilenMetninUzunlugu.Visible = durum;

            // Girilen metnin cümle uzunluðunu gösteren etiket ve metin kutusu
            lblGirilenMetninCumleUzunlugu.Visible = durum;
            txtGirilenMetninCumleUzunlugu.Visible = durum;

            // Kelime sayýsýný gösteren etiket ve metin kutusu
            lblEnKisaKelime.Visible = durum;
            txtEnKisaKelime.Visible = durum;

            // En uzun kelimeyi gösteren etiket ve metin kutusu
            lblEnUzunKelime.Visible = durum;
            txtEnUzunKelime.Visible = durum;

            // Bilgilendirme etiketi
            lblBilgilendirme.Visible = durum;

            btnYeniIcerikSay.Enabled = durum;
            menuYeniIcerikSay.Enabled = durum; // Yeni Ýçerik Say menü öðesini gönderilen duruma göre etkinleþtir veya devre dýþý býrak
        }

        // Referans Metini metin kutusundaki metin her deðiþtiðinde bu olay çalýþýr
        private void txtReferansMetin_TextChanged(object sender, EventArgs e)
        {
            // Düzenleme modunda deðilsek ve metin kutusu boþ deðilse temizle butonunu etkinleþtir
            if (_duzenlemeModundaMi == false && txtReferansMetin.Text.Trim().Length > 0)
            {
                btnTemizle.Enabled = true;
            }
            // Aksi halde temizle butonunu devre dýþý býrak
            else
            {
                btnTemizle.Enabled = false;
            }
        }
    }
}
