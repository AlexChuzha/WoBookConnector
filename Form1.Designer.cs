namespace WoBookTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnAquireToken = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Проверить токен";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(150, 12);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(123, 20);
            this.txtToken.TabIndex = 1;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToken.Location = new System.Drawing.Point(45, 15);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(99, 13);
            this.lblToken.TabIndex = 2;
            this.lblToken.Text = "Токен WoBook:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(100, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(282, 20);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.Text = "https://wubook.net/xrws/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес сервера:";
            // 
            // labResult
            // 
            this.labResult.Location = new System.Drawing.Point(8, 69);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(399, 290);
            this.labResult.TabIndex = 0;
            this.labResult.Text = "Проверьте токен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LCode:";
            // 
            // txtLCode
            // 
            this.txtLCode.Location = new System.Drawing.Point(50, 85);
            this.txtLCode.Name = "txtLCode";
            this.txtLCode.Size = new System.Drawing.Size(86, 20);
            this.txtLCode.TabIndex = 7;
            this.txtLCode.Text = "1506091924";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pass:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(86, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "manager";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(50, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(86, 20);
            this.txtUser.TabIndex = 11;
            this.txtUser.Text = "XE012";
            // 
            // btnAquireToken
            // 
            this.btnAquireToken.Location = new System.Drawing.Point(143, 27);
            this.btnAquireToken.Name = "btnAquireToken";
            this.btnAquireToken.Size = new System.Drawing.Size(123, 75);
            this.btnAquireToken.TabIndex = 12;
            this.btnAquireToken.Text = "Получить токен";
            this.btnAquireToken.UseVisualStyleBackColor = true;
            this.btnAquireToken.Click += new System.EventHandler(this.btnAquireToken_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAquireToken);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.txtLCode);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 372);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Регистрация токена";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 251);
            this.label5.TabIndex = 13;
            this.label5.Text = "Зарегистрируйте токен";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labResult);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtUrl);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(304, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 372);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверка токена";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(15, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 265);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление токена";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 212);
            this.label6.TabIndex = 14;
            this.label6.Text = "Для вывода результата удалите токен";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Удалить токен";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 816);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.txtToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnAquireToken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

