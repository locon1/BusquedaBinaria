namespace Busqueda_binaria
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.cmdVer = new System.Windows.Forms.Button();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            this.cmdLlenar = new System.Windows.Forms.Button();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(135, 269);
            this.cmdBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(62, 24);
            this.cmdBuscar.TabIndex = 23;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(97, 269);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(35, 24);
            this.txtSearch.TabIndex = 22;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 273);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 16);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "Buscar num:";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(15, 141);
            this.txtRes.Margin = new System.Windows.Forms.Padding(2);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(266, 109);
            this.txtRes.TabIndex = 20;
            // 
            // cmdVer
            // 
            this.cmdVer.Location = new System.Drawing.Point(70, 102);
            this.cmdVer.Margin = new System.Windows.Forms.Padding(2);
            this.cmdVer.Name = "cmdVer";
            this.cmdVer.Size = new System.Drawing.Size(62, 23);
            this.cmdVer.TabIndex = 19;
            this.cmdVer.Text = "Ver";
            this.cmdVer.UseVisualStyleBackColor = true;
            this.cmdVer.Click += new System.EventHandler(this.cmdVer_Click);
            // 
            // cmdOrdenar
            // 
            this.cmdOrdenar.Location = new System.Drawing.Point(152, 102);
            this.cmdOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(62, 23);
            this.cmdOrdenar.TabIndex = 18;
            this.cmdOrdenar.Text = "Ordenar";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            // 
            // cmdLlenar
            // 
            this.cmdLlenar.Location = new System.Drawing.Point(194, 59);
            this.cmdLlenar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLlenar.Name = "cmdLlenar";
            this.cmdLlenar.Size = new System.Drawing.Size(62, 23);
            this.cmdLlenar.TabIndex = 17;
            this.cmdLlenar.Text = "Llenar";
            this.cmdLlenar.UseVisualStyleBackColor = true;
            this.cmdLlenar.Click += new System.EventHandler(this.cmdLlenar_Click);
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(71, 64);
            this.lblLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(37, 13);
            this.lblLimit.TabIndex = 16;
            this.lblLimit.Text = "Limite:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(9, 19);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(99, 13);
            this.lblSize.TabIndex = 15;
            this.lblSize.Text = "Tamaño del vector:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(112, 14);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(78, 22);
            this.txtSize.TabIndex = 14;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(112, 59);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimit.Multiline = true;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(78, 23);
            this.txtLimit.TabIndex = 13;
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(194, 14);
            this.cmdCrear.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(62, 22);
            this.cmdCrear.TabIndex = 12;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 298);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 329);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.cmdVer);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.cmdLlenar);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.cmdCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button cmdVer;
        private System.Windows.Forms.Button cmdOrdenar;
        private System.Windows.Forms.Button cmdLlenar;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Label lblResult;
    }
}

