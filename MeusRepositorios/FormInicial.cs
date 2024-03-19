using MeusRepositorios.Domain.Model;
using MeusRepositorios.Service.Interface;

namespace MeusRepositorios
{
    public partial class FormInicial : Form
    {
        private readonly IMyRepositoryService _myRepositoryService;
        public MyRepository _myRepository { get; set; }
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            _myRepository = _myRepositoryService.Get().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
