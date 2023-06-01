using System.Data;

namespace WF_ADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);
            
            dataGridView1.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas where nome = '" + txbNome.Text + "'";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNomeNew.Text;
            p.profissao = txbProfissao.Text;

            if(p.gravarPessoa())
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }
    }
}