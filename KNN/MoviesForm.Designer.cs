namespace KNN
{
    partial class MoviesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_duration = new System.Windows.Forms.Label();
            this.l_imdb = new System.Windows.Forms.Label();
            this.l_date = new System.Windows.Forms.Label();
            this.l_director = new System.Windows.Forms.Label();
            this.l_genre = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.l_actors = new System.Windows.Forms.Label();
            this.l_about = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.l_title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.l_about);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 479);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Uždaryti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.l_duration);
            this.groupBox1.Controls.Add(this.l_imdb);
            this.groupBox1.Controls.Add(this.l_date);
            this.groupBox1.Controls.Add(this.l_director);
            this.groupBox1.Controls.Add(this.l_genre);
            this.groupBox1.Location = new System.Drawing.Point(774, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 428);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // l_duration
            // 
            this.l_duration.AutoSize = true;
            this.l_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_duration.Location = new System.Drawing.Point(24, 322);
            this.l_duration.Name = "l_duration";
            this.l_duration.Size = new System.Drawing.Size(108, 16);
            this.l_duration.TabIndex = 7;
            this.l_duration.Text = "Trukmė: 133 min.";
            // 
            // l_imdb
            // 
            this.l_imdb.AutoSize = true;
            this.l_imdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_imdb.Location = new System.Drawing.Point(24, 273);
            this.l_imdb.Name = "l_imdb";
            this.l_imdb.Size = new System.Drawing.Size(61, 16);
            this.l_imdb.TabIndex = 5;
            this.l_imdb.Text = "imdb: 6.8";
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_date.Location = new System.Drawing.Point(24, 297);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(71, 16);
            this.l_date.TabIndex = 2;
            this.l_date.Text = "Data: 1997";
            // 
            // l_director
            // 
            this.l_director.AutoSize = true;
            this.l_director.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_director.Location = new System.Drawing.Point(24, 347);
            this.l_director.Name = "l_director";
            this.l_director.Size = new System.Drawing.Size(165, 16);
            this.l_director.TabIndex = 6;
            this.l_director.Text = "Režisierius: George Lucas";
            // 
            // l_genre
            // 
            this.l_genre.AutoSize = true;
            this.l_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_genre.Location = new System.Drawing.Point(24, 373);
            this.l_genre.Name = "l_genre";
            this.l_genre.Size = new System.Drawing.Size(120, 16);
            this.l_genre.TabIndex = 4;
            this.l_genre.Text = "Žanras: Fantastinis";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.l_actors);
            this.groupBox4.Location = new System.Drawing.Point(562, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 457);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vaidina";
            // 
            // l_actors
            // 
            this.l_actors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_actors.Location = new System.Drawing.Point(6, 19);
            this.l_actors.Name = "l_actors";
            this.l_actors.Size = new System.Drawing.Size(183, 425);
            this.l_actors.TabIndex = 9;
            this.l_actors.Text = "Vaidina";
            // 
            // l_about
            // 
            this.l_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_about.Location = new System.Drawing.Point(13, 127);
            this.l_about.Name = "l_about";
            this.l_about.Size = new System.Drawing.Size(538, 342);
            this.l_about.TabIndex = 8;
            this.l_about.Text = resources.GetString("l_about.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_title);
            this.groupBox3.Location = new System.Drawing.Point(13, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 48);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_title.Location = new System.Drawing.Point(6, 16);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(379, 20);
            this.l_title.TabIndex = 1;
            this.l_title.Text = "Žvaigždžių karai: epizodas I – pavojaus šešėlis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 48);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Epizodas 1",
            "Epizodas 2",
            "Epizodas 3",
            "Epizodas 4",
            "Epizodas 5",
            "Epizodas 6",
            "Epizodas 7"});
            this.comboBox1.Location = new System.Drawing.Point(142, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pasirinkite filmą:";
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 495);
            this.Controls.Add(this.panel1);
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoviesForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_duration;
        private System.Windows.Forms.Label l_director;
        private System.Windows.Forms.Label l_imdb;
        private System.Windows.Forms.Label l_genre;
        private System.Windows.Forms.Label l_about;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_actors;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}