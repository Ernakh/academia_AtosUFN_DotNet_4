
namespace WindowsFormsSerialização
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
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDesserializar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDesserializar = new System.Windows.Forms.TextBox();
            this.txbSerializar = new System.Windows.Forms.TextBox();
            this.SOAP = new System.Windows.Forms.GroupBox();
            this.btnDesserializar2 = new System.Windows.Forms.Button();
            this.btnSerializar2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesserializarJson = new System.Windows.Forms.Button();
            this.btnSerializarJson = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDesserializarXML = new System.Windows.Forms.Button();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SOAP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(6, 45);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(75, 23);
            this.btnSerializar.TabIndex = 0;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDesserializar
            // 
            this.btnDesserializar.Location = new System.Drawing.Point(193, 45);
            this.btnDesserializar.Name = "btnDesserializar";
            this.btnDesserializar.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializar.TabIndex = 1;
            this.btnDesserializar.Text = "Desserializar";
            this.btnDesserializar.UseVisualStyleBackColor = true;
            this.btnDesserializar.Click += new System.EventHandler(this.btnDesserializar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDesserializar);
            this.groupBox1.Controls.Add(this.txbSerializar);
            this.groupBox1.Controls.Add(this.btnSerializar);
            this.groupBox1.Controls.Add(this.btnDesserializar);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simples";
            // 
            // txbDesserializar
            // 
            this.txbDesserializar.Location = new System.Drawing.Point(193, 19);
            this.txbDesserializar.Name = "txbDesserializar";
            this.txbDesserializar.Size = new System.Drawing.Size(100, 20);
            this.txbDesserializar.TabIndex = 3;
            // 
            // txbSerializar
            // 
            this.txbSerializar.Location = new System.Drawing.Point(6, 19);
            this.txbSerializar.Name = "txbSerializar";
            this.txbSerializar.Size = new System.Drawing.Size(100, 20);
            this.txbSerializar.TabIndex = 2;
            // 
            // SOAP
            // 
            this.SOAP.Controls.Add(this.btnDesserializar2);
            this.SOAP.Controls.Add(this.btnSerializar2);
            this.SOAP.Location = new System.Drawing.Point(41, 144);
            this.SOAP.Name = "SOAP";
            this.SOAP.Size = new System.Drawing.Size(279, 114);
            this.SOAP.TabIndex = 3;
            this.SOAP.TabStop = false;
            this.SOAP.Text = "SOAP";
            // 
            // btnDesserializar2
            // 
            this.btnDesserializar2.Location = new System.Drawing.Point(163, 51);
            this.btnDesserializar2.Name = "btnDesserializar2";
            this.btnDesserializar2.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializar2.TabIndex = 4;
            this.btnDesserializar2.Text = "Desserializar";
            this.btnDesserializar2.UseVisualStyleBackColor = true;
            this.btnDesserializar2.Click += new System.EventHandler(this.btnDesserializar2_Click);
            // 
            // btnSerializar2
            // 
            this.btnSerializar2.Location = new System.Drawing.Point(22, 51);
            this.btnSerializar2.Name = "btnSerializar2";
            this.btnSerializar2.Size = new System.Drawing.Size(75, 23);
            this.btnSerializar2.TabIndex = 4;
            this.btnSerializar2.Text = "Serializar";
            this.btnSerializar2.UseVisualStyleBackColor = true;
            this.btnSerializar2.Click += new System.EventHandler(this.btnSerializar2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDesserializarJson);
            this.groupBox2.Controls.Add(this.btnSerializarJson);
            this.groupBox2.Location = new System.Drawing.Point(401, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JSON";
            // 
            // btnDesserializarJson
            // 
            this.btnDesserializarJson.Location = new System.Drawing.Point(163, 51);
            this.btnDesserializarJson.Name = "btnDesserializarJson";
            this.btnDesserializarJson.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializarJson.TabIndex = 4;
            this.btnDesserializarJson.Text = "Desserializar";
            this.btnDesserializarJson.UseVisualStyleBackColor = true;
            this.btnDesserializarJson.Click += new System.EventHandler(this.btnDesserializarJson_Click);
            // 
            // btnSerializarJson
            // 
            this.btnSerializarJson.Location = new System.Drawing.Point(22, 51);
            this.btnSerializarJson.Name = "btnSerializarJson";
            this.btnSerializarJson.Size = new System.Drawing.Size(75, 23);
            this.btnSerializarJson.TabIndex = 4;
            this.btnSerializarJson.Text = "Serializar";
            this.btnSerializarJson.UseVisualStyleBackColor = true;
            this.btnSerializarJson.Click += new System.EventHandler(this.btnSerializarJson_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDesserializarXML);
            this.groupBox3.Controls.Add(this.btnSerializarXML);
            this.groupBox3.Location = new System.Drawing.Point(401, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 114);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML";
            // 
            // btnDesserializarXML
            // 
            this.btnDesserializarXML.Location = new System.Drawing.Point(163, 51);
            this.btnDesserializarXML.Name = "btnDesserializarXML";
            this.btnDesserializarXML.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializarXML.TabIndex = 4;
            this.btnDesserializarXML.Text = "Desserializar";
            this.btnDesserializarXML.UseVisualStyleBackColor = true;
            this.btnDesserializarXML.Click += new System.EventHandler(this.btnDesserializarXML_Click);
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Location = new System.Drawing.Point(22, 51);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(75, 23);
            this.btnSerializarXML.TabIndex = 4;
            this.btnSerializarXML.Text = "Serializar";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SOAP);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SOAP.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnDesserializar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbDesserializar;
        private System.Windows.Forms.TextBox txbSerializar;
        private System.Windows.Forms.GroupBox SOAP;
        private System.Windows.Forms.Button btnDesserializar2;
        private System.Windows.Forms.Button btnSerializar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDesserializarJson;
        private System.Windows.Forms.Button btnSerializarJson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDesserializarXML;
        private System.Windows.Forms.Button btnSerializarXML;
    }
}

