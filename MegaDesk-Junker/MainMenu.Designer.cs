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
            this.add_new_quote = new System.Windows.Forms.Button();
            this.view_quotes = new System.Windows.Forms.Button();
            this.search_quotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.desk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.desk)).BeginInit();
            this.SuspendLayout();
            // 
            // add_new_quote
            // 
            this.add_new_quote.BackColor = System.Drawing.SystemColors.Control;
            this.add_new_quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_quote.Location = new System.Drawing.Point(20, 19);
            this.add_new_quote.Name = "add_new_quote";
            this.add_new_quote.Size = new System.Drawing.Size(175, 35);
            this.add_new_quote.TabIndex = 0;
            this.add_new_quote.Text = "Add New Quote";
            this.add_new_quote.UseVisualStyleBackColor = false;
            this.add_new_quote.Click += new System.EventHandler(this.OpenAddNewQuote);
            // 
            // view_quotes
            // 
            this.view_quotes.BackColor = System.Drawing.SystemColors.Control;
            this.view_quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_quotes.Location = new System.Drawing.Point(20, 60);
            this.view_quotes.Name = "view_quotes";
            this.view_quotes.Size = new System.Drawing.Size(175, 35);
            this.view_quotes.TabIndex = 1;
            this.view_quotes.Text = "View Quotes";
            this.view_quotes.UseVisualStyleBackColor = false;
            this.view_quotes.Click += new System.EventHandler(this.OpenViewQuotes);
            // 
            // search_quotes
            // 
            this.search_quotes.BackColor = System.Drawing.SystemColors.Control;
            this.search_quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_quotes.Location = new System.Drawing.Point(20, 101);
            this.search_quotes.Name = "search_quotes";
            this.search_quotes.Size = new System.Drawing.Size(175, 35);
            this.search_quotes.TabIndex = 2;
            this.search_quotes.Text = "Search Quotes";
            this.search_quotes.UseVisualStyleBackColor = false;
            this.search_quotes.Click += new System.EventHandler(this.OpenDisplayQuote);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(20, 142);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(175, 35);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit);
            // 
            // desk
            // 
            this.desk.Image = global::MegaDesk_Junker.Properties.Resources.view_3d_school_desk;
            this.desk.Location = new System.Drawing.Point(231, 23);
            this.desk.Name = "desk";
            this.desk.Size = new System.Drawing.Size(150, 150);
            this.desk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.desk.TabIndex = 4;
            this.desk.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 193);
            this.Controls.Add(this.desk);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search_quotes);
            this.Controls.Add(this.view_quotes);
            this.Controls.Add(this.add_new_quote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.desk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

