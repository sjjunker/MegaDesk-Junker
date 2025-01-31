namespace MegaDesk_Junker
{
    partial class MainMenu: System.Windows.Forms.Form
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
         this.addNewQuote = new System.Windows.Forms.Button();
         this.viewQuotes = new System.Windows.Forms.Button();
         this.searchQuotes = new System.Windows.Forms.Button();
         this.exit = new System.Windows.Forms.Button();
         this.desk = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.desk)).BeginInit();
         this.SuspendLayout();
         // 
         // addNewQuote
         // 
         this.addNewQuote.BackColor = System.Drawing.SystemColors.Control;
         this.addNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addNewQuote.Location = new System.Drawing.Point(27, 23);
         this.addNewQuote.Margin = new System.Windows.Forms.Padding(4);
         this.addNewQuote.Name = "addNewQuote";
         this.addNewQuote.Size = new System.Drawing.Size(233, 43);
         this.addNewQuote.TabIndex = 0;
         this.addNewQuote.Text = "Add New Quote";
         this.addNewQuote.UseVisualStyleBackColor = false;
         this.addNewQuote.Click += new System.EventHandler(this.OpenAddNewQuote);
         // 
         // viewQuotes
         // 
         this.viewQuotes.BackColor = System.Drawing.SystemColors.Control;
         this.viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.viewQuotes.Location = new System.Drawing.Point(27, 74);
         this.viewQuotes.Margin = new System.Windows.Forms.Padding(4);
         this.viewQuotes.Name = "viewQuotes";
         this.viewQuotes.Size = new System.Drawing.Size(233, 43);
         this.viewQuotes.TabIndex = 1;
         this.viewQuotes.Text = "View Quotes";
         this.viewQuotes.UseVisualStyleBackColor = false;
         this.viewQuotes.Click += new System.EventHandler(this.OpenViewQuotes);
         // 
         // searchQuotes
         // 
         this.searchQuotes.BackColor = System.Drawing.SystemColors.Control;
         this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.searchQuotes.Location = new System.Drawing.Point(27, 124);
         this.searchQuotes.Margin = new System.Windows.Forms.Padding(4);
         this.searchQuotes.Name = "searchQuotes";
         this.searchQuotes.Size = new System.Drawing.Size(233, 43);
         this.searchQuotes.TabIndex = 2;
         this.searchQuotes.Text = "Search Quotes";
         this.searchQuotes.UseVisualStyleBackColor = false;
         this.searchQuotes.Click += new System.EventHandler(this.OpenSearchQuotes);
         // 
         // exit
         // 
         this.exit.BackColor = System.Drawing.SystemColors.Control;
         this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.exit.Location = new System.Drawing.Point(27, 175);
         this.exit.Margin = new System.Windows.Forms.Padding(4);
         this.exit.Name = "exit";
         this.exit.Size = new System.Drawing.Size(233, 43);
         this.exit.TabIndex = 3;
         this.exit.Text = "Exit";
         this.exit.UseVisualStyleBackColor = false;
         this.exit.Click += new System.EventHandler(this.Exit);
         // 
         // desk
         // 
         this.desk.Image = global::MegaDesk_Junker.Properties.Resources.view_3d_school_desk;
         this.desk.Location = new System.Drawing.Point(308, 28);
         this.desk.Margin = new System.Windows.Forms.Padding(4);
         this.desk.Name = "desk";
         this.desk.Size = new System.Drawing.Size(200, 185);
         this.desk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.desk.TabIndex = 4;
         this.desk.TabStop = false;
         // 
         // MainMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(553, 238);
         this.Controls.Add(this.desk);
         this.Controls.Add(this.exit);
         this.Controls.Add(this.searchQuotes);
         this.Controls.Add(this.viewQuotes);
         this.Controls.Add(this.addNewQuote);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "MainMenu";
         this.Text = "MegaDesk";
         this.Load += new System.EventHandler(this.MainMenuLoad);
         ((System.ComponentModel.ISupportInitialize)(this.desk)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion
    }
}

