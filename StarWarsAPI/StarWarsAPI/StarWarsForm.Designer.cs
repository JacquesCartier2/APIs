
namespace StarWarsAPI
{
    partial class StarWarsForm
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
            this.txb_Input = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Planet = new System.Windows.Forms.Button();
            this.btn_Person = new System.Windows.Forms.Button();
            this.btn_Species = new System.Windows.Forms.Button();
            this.lbx_Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txb_Input
            // 
            this.txb_Input.Location = new System.Drawing.Point(35, 12);
            this.txb_Input.Name = "txb_Input";
            this.txb_Input.Size = new System.Drawing.Size(100, 23);
            this.txb_Input.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(8, 15);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 15);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID:";
            // 
            // btn_Planet
            // 
            this.btn_Planet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Planet.Location = new System.Drawing.Point(35, 51);
            this.btn_Planet.Name = "btn_Planet";
            this.btn_Planet.Size = new System.Drawing.Size(100, 32);
            this.btn_Planet.TabIndex = 2;
            this.btn_Planet.Text = "Get Planet";
            this.btn_Planet.UseVisualStyleBackColor = true;
            this.btn_Planet.Click += new System.EventHandler(this.btn_Planet_Click);
            // 
            // btn_Person
            // 
            this.btn_Person.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Person.Location = new System.Drawing.Point(35, 100);
            this.btn_Person.Name = "btn_Person";
            this.btn_Person.Size = new System.Drawing.Size(100, 32);
            this.btn_Person.TabIndex = 3;
            this.btn_Person.Text = "Get Person";
            this.btn_Person.UseVisualStyleBackColor = true;
            this.btn_Person.Click += new System.EventHandler(this.btn_Person_Click);
            // 
            // btn_Species
            // 
            this.btn_Species.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Species.Location = new System.Drawing.Point(35, 150);
            this.btn_Species.Name = "btn_Species";
            this.btn_Species.Size = new System.Drawing.Size(100, 48);
            this.btn_Species.TabIndex = 4;
            this.btn_Species.Text = "Get All Species";
            this.btn_Species.UseVisualStyleBackColor = true;
            this.btn_Species.Click += new System.EventHandler(this.btn_Species_Click);
            // 
            // lbx_Output
            // 
            this.lbx_Output.FormattingEnabled = true;
            this.lbx_Output.ItemHeight = 15;
            this.lbx_Output.Location = new System.Drawing.Point(141, 12);
            this.lbx_Output.Name = "lbx_Output";
            this.lbx_Output.Size = new System.Drawing.Size(371, 289);
            this.lbx_Output.TabIndex = 5;
            // 
            // StarWarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 322);
            this.Controls.Add(this.lbx_Output);
            this.Controls.Add(this.btn_Species);
            this.Controls.Add(this.btn_Person);
            this.Controls.Add(this.btn_Planet);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txb_Input);
            this.Name = "StarWarsForm";
            this.Text = "StarWarsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Input;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Planet;
        private System.Windows.Forms.Button btn_Person;
        private System.Windows.Forms.Button btn_Species;
        private System.Windows.Forms.ListBox lbx_Output;
    }
}

