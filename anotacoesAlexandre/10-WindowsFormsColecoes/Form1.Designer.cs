namespace _10_WindowsFormsColecoes
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
            label1 = new Label();
            label2 = new Label();
            buttonGravar = new Button();
            textBoxNome = new TextBox();
            textBoxDataNascimento = new TextBox();
            listBoxPessoas = new ListBox();
            buttonRemover = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Data nascimento";
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(111, 77);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(75, 23);
            buttonGravar.TabIndex = 2;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(112, 9);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(197, 23);
            textBoxNome.TabIndex = 3;
            textBoxNome.KeyUp += textBoxNome_KeyUp;
            // 
            // textBoxDataNascimento
            // 
            textBoxDataNascimento.Location = new Point(114, 42);
            textBoxDataNascimento.Name = "textBoxDataNascimento";
            textBoxDataNascimento.Size = new Size(195, 23);
            textBoxDataNascimento.TabIndex = 4;
            // 
            // listBoxPessoas
            // 
            listBoxPessoas.FormattingEnabled = true;
            listBoxPessoas.ItemHeight = 15;
            listBoxPessoas.Location = new Point(328, 9);
            listBoxPessoas.Name = "listBoxPessoas";
            listBoxPessoas.Size = new Size(291, 199);
            listBoxPessoas.Sorted = true;
            listBoxPessoas.TabIndex = 5;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(204, 77);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 6;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 224);
            Controls.Add(buttonRemover);
            Controls.Add(listBoxPessoas);
            Controls.Add(textBoxDataNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(buttonGravar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonGravar;
        private TextBox textBoxNome;
        private TextBox textBoxDataNascimento;
        private ListBox listBoxPessoas;
        private Button buttonRemover;
    }
}