namespace WinFormsApp1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.products = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.addElementPanel = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.elementName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.checkText = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.helperBox = new System.Windows.Forms.CheckBox();
            this.productsPanel.SuspendLayout();
            this.addElementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.ItemHeight = 15;
            this.products.Location = new System.Drawing.Point(3, 18);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(178, 169);
            this.products.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.products);
            this.productsPanel.Controls.Add(this.label1);
            this.productsPanel.Location = new System.Drawing.Point(12, 12);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(194, 200);
            this.productsPanel.TabIndex = 3;
            // 
            // addElementPanel
            // 
            this.addElementPanel.Controls.Add(this.add);
            this.addElementPanel.Controls.Add(this.date);
            this.addElementPanel.Controls.Add(this.elementName);
            this.addElementPanel.Controls.Add(this.label2);
            this.addElementPanel.Location = new System.Drawing.Point(212, 12);
            this.addElementPanel.Name = "addElementPanel";
            this.addElementPanel.Size = new System.Drawing.Size(200, 105);
            this.addElementPanel.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 76);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(194, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add element";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(3, 47);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(194, 23);
            this.date.TabIndex = 2;
            // 
            // elementName
            // 
            this.elementName.Location = new System.Drawing.Point(3, 18);
            this.elementName.Name = "elementName";
            this.elementName.Size = new System.Drawing.Size(194, 23);
            this.elementName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add element";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 218);
            this.check.Name = "check";
            this.check.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check.Size = new System.Drawing.Size(194, 23);
            this.check.TabIndex = 0;
            this.check.Text = "Check expiration date";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // checkText
            // 
            this.checkText.AutoSize = true;
            this.checkText.Location = new System.Drawing.Point(12, 244);
            this.checkText.Name = "checkText";
            this.checkText.Size = new System.Drawing.Size(0, 15);
            this.checkText.TabIndex = 5;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(12, 262);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(194, 23);
            this.del.TabIndex = 6;
            this.del.Text = "Delete expired products";
            this.del.UseVisualStyleBackColor = true;
            this.del.Visible = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // helperBox
            // 
            this.helperBox.AutoSize = true;
            this.helperBox.Location = new System.Drawing.Point(212, 123);
            this.helperBox.Name = "helperBox";
            this.helperBox.Size = new System.Drawing.Size(171, 19);
            this.helperBox.TabIndex = 7;
            this.helperBox.Text = "Allow to add expired values";
            this.helperBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 299);
            this.Controls.Add(this.helperBox);
            this.Controls.Add(this.del);
            this.Controls.Add(this.checkText);
            this.Controls.Add(this.check);
            this.Controls.Add(this.addElementPanel);
            this.Controls.Add(this.productsPanel);
            this.Name = "Form1";
            this.Text = "Product List";
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            this.addElementPanel.ResumeLayout(false);
            this.addElementPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox products;
        private Label label1;
        private Panel productsPanel;
        private Panel addElementPanel;
        private Label label2;
        private DateTimePicker date;
        private TextBox elementName;
        private Button add;
        private Button check;
        private Label checkText;
        private Button del;
        private CheckBox helperBox;
    }
}