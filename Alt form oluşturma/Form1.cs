using System;
using System.Windows.Forms;

namespace Alt_form_oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 1; // her adımda oluşacak yeni formun adını farklı yapabilmek için bir değişken tanımladık.
        int b;


        private void button1_Click(object sender, EventArgs e)
        {

            // FORM OLUŞTUR BUTONU

            b=a++; // Değeri her tıklanışta bir artırdık.

            AltForm cocuk = new AltForm(); // Programa cocuk adında bir form oluşturması gerektiğini söyledik.

            cocuk.Name = "cocuk" + b.ToString(); // yeni oluşan formun adını atadık.

            cocuk.Text = "Yeni Alt Form " + b.ToString(); // textinde görmek istediğimiz şeyi yazdık.

            cocuk.MdiParent = this; // ana formun cocuk ismi ile oluşturduğumuz formun parent ı yani bir üst formu olduğunu söyledik.

            cocuk.Show(); // formumuzu gösterdik


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FORM SİL BUTONU


            if (ActiveMdiChild != null) // acitive alt formumuz varmı diye sorduk var ise alttaki işlemleri yap dedik
            {
                Form frm = ActiveMdiChild; // ana form kapsayıcıya aktif olan formu atadık.
                frm.Close(); // ve formu kapattıkk.
                a--; // değişkenimizi bir azalttık

            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TÜM FORMLARI SİL BUTONU

            foreach (Form frm in this.MdiChildren) //tüm formları silebilmek için döngüye sokup tüm formları kapattık
            {
                frm.Close();
                a = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
