
namespace Hava_Durumu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtmaxtemp = new System.Windows.Forms.TextBox();
            this.txtmintemp = new System.Windows.Forms.TextBox();
            this.txtwind = new System.Windows.Forms.TextBox();
            this.txthumidity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Sıcaklık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Sıcaklık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rüzgar Hızı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nem";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(242, 54);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(283, 26);
            this.txtcity.TabIndex = 6;
            // 
            // txtmaxtemp
            // 
            this.txtmaxtemp.Location = new System.Drawing.Point(242, 131);
            this.txtmaxtemp.Name = "txtmaxtemp";
            this.txtmaxtemp.Size = new System.Drawing.Size(283, 26);
            this.txtmaxtemp.TabIndex = 7;
            // 
            // txtmintemp
            // 
            this.txtmintemp.Location = new System.Drawing.Point(242, 182);
            this.txtmintemp.Name = "txtmintemp";
            this.txtmintemp.Size = new System.Drawing.Size(283, 26);
            this.txtmintemp.TabIndex = 8;
            // 
            // txtwind
            // 
            this.txtwind.Location = new System.Drawing.Point(242, 235);
            this.txtwind.Name = "txtwind";
            this.txtwind.Size = new System.Drawing.Size(283, 26);
            this.txtwind.TabIndex = 9;
            // 
            // txthumidity
            // 
            this.txthumidity.Location = new System.Drawing.Point(242, 290);
            this.txthumidity.Name = "txthumidity";
            this.txthumidity.Size = new System.Drawing.Size(283, 26);
            this.txthumidity.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(636, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 262);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hava Durumu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 503);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 245);
            this.dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 782);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 63);
            this.button2.TabIndex = 14;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcountry
            // 
            this.txtcountry.Location = new System.Drawing.Point(636, 24);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(306, 26);
            this.txtcountry.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hava_Durumu.Properties.Resources._360_F_212000291_DJ9d5qj6o67FV8hsjCMnOMEF10fwiIDm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 894);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txthumidity);
            this.Controls.Add(this.txtwind);
            this.Controls.Add(this.txtmintemp);
            this.Controls.Add(this.txtmaxtemp);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hava Durumu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtmaxtemp;
        private System.Windows.Forms.TextBox txtmintemp;
        private System.Windows.Forms.TextBox txtwind;
        private System.Windows.Forms.TextBox txthumidity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcountry;
    }
}

