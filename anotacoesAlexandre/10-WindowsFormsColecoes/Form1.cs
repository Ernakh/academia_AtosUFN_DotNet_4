using System.Windows.Forms;

namespace _10_WindowsFormsColecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxDataNascimento.Text == "")
            {
                MessageBox.Show("Os dois campos precisam ser preenchidos");
                return;
            }
            textBoxNome.Text = textBoxNome.Text.ToUpper();
            try
            {
                Pessoa p = new Pessoa(textBoxNome.Text, DateOnly.Parse(textBoxDataNascimento.Text));
                if (!listBoxPessoas.Items.Contains(p))
                {
                    if (listBoxPessoas.Items.Count > 0)
                    {
                        Pessoa pqq = (Pessoa)listBoxPessoas.Items[0];
                        MessageBox.Show("Comparar idades de: " + p + " com " + pqq);

                        MessageBox.Show("Diferença de idade: " + Math.Abs((p.DataNascimento.DayNumber - pqq.DataNascimento.DayNumber) / 365));

                    }

                    listBoxPessoas.Items.Add(p);
                }
                else
                {
                    MessageBox.Show(p + " já inserido na estrutura");
                }

                textBoxNome.Clear();
                textBoxDataNascimento.Clear();
            }
            catch
            {
                MessageBox.Show("Problemas com o formato da data! Use dd/mm/aaaa");
                textBoxDataNascimento.Clear();
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPessoas.SelectedItem != null)
            {
                listBoxPessoas.Items.Remove(listBoxPessoas.SelectedItem);
                return;
            }


            if (textBoxNome.Text == "" || textBoxDataNascimento.Text == "")
            {
                MessageBox.Show("Os dois campos precisam ser preenchidos");
                return;
            }
            textBoxNome.Text = textBoxNome.Text.ToUpper();
            Pessoa p = new Pessoa(textBoxNome.Text, DateOnly.Parse(textBoxDataNascimento.Text));
            listBoxPessoas.Items.Remove(p);
            textBoxNome.Clear();
            textBoxDataNascimento.Clear();
        }

        private void textBoxNome_KeyUp(object sender, KeyEventArgs e)
        {
            string frase = textBoxNome.Text.ToUpper();

            foreach (var item in listBoxPessoas.Items)
            {
                if (item.ToString().Contains(frase))
                {
                    //MessageBox.Show("Feito");
                }
            }
        }
    }
}