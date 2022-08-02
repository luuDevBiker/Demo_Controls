namespace Demo_Controls_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(string disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv_Book = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cbb_Price = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Book
            // 
            this.Dgv_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Book.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Book.Location = new System.Drawing.Point(0, 311);
            this.Dgv_Book.Name = "Dgv_Book";
            this.Dgv_Book.RowHeadersWidth = 51;
            this.Dgv_Book.RowTemplate.Height = 29;
            this.Dgv_Book.Size = new System.Drawing.Size(1085, 396);
            this.Dgv_Book.TabIndex = 0;
            this.Dgv_Book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Book_CellClick);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(846, 244);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(207, 45);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(579, 244);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(221, 45);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(307, 244);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(221, 45);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(23, 244);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(221, 45);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(127, 33);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "Name";
            this.txt_Name.Size = new System.Drawing.Size(374, 27);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(127, 81);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.PlaceholderText = "Title";
            this.txt_Title.Size = new System.Drawing.Size(374, 27);
            this.txt_Title.TabIndex = 3;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(617, 33);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.PlaceholderText = "Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(374, 27);
            this.txt_Quantity.TabIndex = 3;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(619, 81);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PlaceholderText = "Price";
            this.txt_Price.Size = new System.Drawing.Size(374, 27);
            this.txt_Price.TabIndex = 3;
            // 
            // cbb_Price
            // 
            this.cbb_Price.FormattingEnabled = true;
            this.cbb_Price.Location = new System.Drawing.Point(127, 132);
            this.cbb_Price.Name = "cbb_Price";
            this.cbb_Price.Size = new System.Drawing.Size(374, 28);
            this.cbb_Price.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 707);
            this.Controls.Add(this.cbb_Price);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.Dgv_Book);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Dgv_Book;
        private Button btn_load;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private TextBox txt_Name;
        private TextBox txt_Title;
        private TextBox txt_Quantity;
        private TextBox txt_Price;
        private ComboBox cbb_Price;
    }
}