namespace atividade01.View
{
    partial class AtividadeSoma
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
            lbl_Soma = new Label();
            lbl_valor1 = new Label();
            lbl_valor2 = new Label();
            lbl_somar = new Label();
            txb_1 = new MaskedTextBox();
            txb_2 = new MaskedTextBox();
            btn_somar = new Button();
            SuspendLayout();
            // 
            // lbl_Soma
            // 
            lbl_Soma.AutoSize = true;
            lbl_Soma.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Soma.Location = new Point(257, 35);
            lbl_Soma.Name = "lbl_Soma";
            lbl_Soma.Size = new Size(319, 36);
            lbl_Soma.TabIndex = 0;
            lbl_Soma.Text = "Soma dois Valores";
            // 
            // lbl_valor1
            // 
            lbl_valor1.AutoSize = true;
            lbl_valor1.Location = new Point(194, 119);
            lbl_valor1.Name = "lbl_valor1";
            lbl_valor1.Size = new Size(45, 15);
            lbl_valor1.TabIndex = 1;
            lbl_valor1.Text = "Valor 1 ";
            // 
            // lbl_valor2
            // 
            lbl_valor2.AutoSize = true;
            lbl_valor2.Location = new Point(194, 170);
            lbl_valor2.Name = "lbl_valor2";
            lbl_valor2.Size = new Size(42, 15);
            lbl_valor2.TabIndex = 2;
            lbl_valor2.Text = "Valor 2";
            // 
            // lbl_somar
            // 
            lbl_somar.BackColor = SystemColors.ActiveCaption;
            lbl_somar.Location = new Point(321, 215);
            lbl_somar.Name = "lbl_somar";
            lbl_somar.Size = new Size(176, 69);
            lbl_somar.TabIndex = 3;
            // 
            // txb_1
            // 
            txb_1.Location = new Point(275, 116);
            txb_1.Name = "txb_1";
            txb_1.Size = new Size(279, 23);
            txb_1.TabIndex = 4;
            // 
            // txb_2
            // 
            txb_2.Location = new Point(275, 170);
            txb_2.Name = "txb_2";
            txb_2.Size = new Size(279, 23);
            txb_2.TabIndex = 5;
            // 
            // btn_somar
            // 
            btn_somar.Location = new Point(339, 337);
            btn_somar.Name = "btn_somar";
            btn_somar.Size = new Size(147, 57);
            btn_somar.TabIndex = 6;
            btn_somar.Text = "Somar";
            btn_somar.UseVisualStyleBackColor = true;
            btn_somar.Click += btn_somar_Click;
            // 
            // AtividadeSoma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_somar);
            Controls.Add(txb_2);
            Controls.Add(txb_1);
            Controls.Add(lbl_somar);
            Controls.Add(lbl_valor2);
            Controls.Add(lbl_valor1);
            Controls.Add(lbl_Soma);
            Name = "AtividadeSoma";
            Text = "AtividadeSoma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Soma;
        private Label lbl_valor1;
        private Label lbl_valor2;
        private Label lbl_somar;
        private MaskedTextBox txb_1;
        private MaskedTextBox txb_2;
        private Button btn_somar;
    }
}